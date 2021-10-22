using System;
using System.Collections.Generic;

namespace Educ
{

    class Test
    {
        private string name;


        public Test(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Test a = new Test("gdfgdf");
            Test b = new Test("Kostadin");
            //a.Name = "gdfgdf";

            //Console.WriteLine(a.Name + " " + b.Name);

            List<Test> a = new List<Test>();

            a.Add(new Test("dfsgdfgdf"));
            a.Add(b);

            Console.WriteLine(a[0].Name + " " + a[1].Name);


        }
    }
}
