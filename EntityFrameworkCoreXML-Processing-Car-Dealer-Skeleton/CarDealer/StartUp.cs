using CarDealer.Data;
using CarDealer.Dto.ExportDto;
using CarDealer.Dto.ImportDto;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        //private static readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg 
        //    => { cfg.AddProfile<CarDealerProfile>(); 
        //    }));

        public static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();

            //string inputXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //string inputXml = File.ReadAllText("../../../Datasets/parts.xml");
            //string inputXml = File.ReadAllText("../../../Datasets/cars.xml");
            //string inputXml = File.ReadAllText("../../../Datasets/customers.xml");
            string inputXml = File.ReadAllText("../../../Datasets/sales.xml");

            //string resultSuppliers = ImportSuppliers(dbContext, inputXml);
            //string resultParts = ImportParts(dbContext, inputXml);
            //string resultCars = ImportCars(dbContext, inputXml);
            //string resultCustomers = ImportCustomers(dbContext, inputXml);
            // string resultSales = ImportSales(dbContext, inputXml);

            Console.WriteLine(GetCarsWithDistance(dbContext));

        }

        private static void DbReset(CarDealerContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            Console.WriteLine("DB reset success");
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Suppliers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportSupplierDto[] dtos = (ImportSupplierDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Supplier> suppliers = new HashSet<Supplier>();

            foreach (ImportSupplierDto supplierDto in dtos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDto.Name,
                    IsImporter = bool.Parse(supplierDto.isImporter)
                };

                suppliers.Add(s);

            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}";

        }
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Parts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportPartDto[] dtos = (ImportPartDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Part> parts = new HashSet<Part>();

            foreach (ImportPartDto dto in dtos)
            {

                Supplier supplier = context.Suppliers.Find(dto.SupplierId);

                if (supplier == null)
                {
                    continue;
                }

                Part p = new Part()
                {
                    Name = dto.Name,
                    Price = decimal.Parse(dto.Price),
                    Quantity = dto.Quantity,
                    SupplierId = supplier.Id
                };

                parts.Add(p);

            }

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";

        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Cars");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCarDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportCarDto[] carDtos = (ImportCarDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Car> cars = new HashSet<Car>();
            //ICollection<PartCar> partCars = new HashSet<PartCar>();

            foreach (ImportCarDto dto in carDtos)
            {
                Car car = new Car()
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    TravelledDistance = dto.TraveledDistance,
                };

                ICollection<PartCar> currentCarParts = new HashSet<PartCar>();

                foreach (int partId in dto.Parts.Select(p => p.Id).Distinct())
                {
                    Part p = context.Parts.Find(partId);

                    if (p == null)
                    {
                        continue;
                    }

                    PartCar partCar = new PartCar()
                    {
                        Car = car,
                        Part = p,
                    };

                    currentCarParts.Add(partCar);
                }

                car.PartCars = currentCarParts;
                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";

        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Customers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCustomerDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportCustomerDto[] customersDtos = (ImportCustomerDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Customer> customers = new HashSet<Customer>();

            foreach (ImportCustomerDto dto in customersDtos)
            {
                Customer c = new Customer()
                {
                    Name = dto.Name,
                    BirthDate = DateTime.Parse(dto.BirthDate),
                    IsYoungDriver = bool.Parse(dto.IsYoungDriver)
                };

                customers.Add(c);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count()}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Sales");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSaleDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportSaleDto[] customersDtos = (ImportSaleDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Sale> sales = new HashSet<Sale>();

            foreach (ImportSaleDto dto in customersDtos)
            {
                Car car = context.Cars.Find(dto.CarId);

                if (car == null)
                {
                    continue;
                }

                Sale s = new Sale()
                {
                    CarId = dto.CarId,
                    CustomerId = dto.CustomerId,
                    Discount = dto.Discount
                };

                sales.Add(s);
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count()}";
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlRootAttribute xmlRoot = new XmlRootAttribute("cars");
             XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCarsWithDistanceDto[]), xmlRoot);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            ExportCarsWithDistanceDto[] carsDtos = context
                .Cars
                .Where(c => c.TravelledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new ExportCarsWithDistanceDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();


            xmlSerializer.Serialize(stringWriter, carsDtos, namespaces);

            return sb.ToString().TrimEnd();

        }

    }
}