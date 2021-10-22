using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        public static void Main()
        {
            string line;

            Dictionary<string, ISoldier> soldiersById = new Dictionary<string, ISoldier>();

            while ((line = Console.ReadLine()) != "End")
             {
                string[] arguments = line.Split();
                string type = arguments[0];
                string id = arguments[1];
                string firstName = arguments[2];
                string lastname = arguments[3];

                if (type == nameof(Private))
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    soldiersById[id] = new Private(id, firstName, lastname, salary);
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastname, salary);

                    for (int i = 5; i < arguments.Length; i++)
                    {
                        string privateId = arguments[i];

                        lieutenantGeneral.AddPrivate((IPrivate)soldiersById[privateId]);
                        
                        if (soldiersById.ContainsKey(privateId))
                        {
                            continue;
                        }

                    }

                    soldiersById[id] = lieutenantGeneral;

                }
                else if (type == nameof(Engineer))
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    bool isCorpsValid = Enum.TryParse(arguments[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastname, salary, corps);

                    for (int i = 6; i < arguments.Length; i+=2)
                    {
                        string part = arguments[i];
                        int hoursWorked = int.Parse(arguments[i + 1]);

                        IRepair repair = new Repair(part, hoursWorked);

                        engineer.AddRepair(repair);
                    }

                    soldiersById[id] = engineer;

                }
                else if (type == nameof(Commando))
                {
                    decimal salary = decimal.Parse(arguments[4]);
                    
                    bool isCorpsValid = Enum.TryParse(arguments[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }

                    ICommando comanndo = new Commando(id, firstName, lastname, salary, corps);

                    for (int i = 6; i < arguments.Length; i += 2)
                    {
                        string codeName = arguments[i];
                        string state = arguments[i + 1];
                        bool isMissionStateVliad = Enum.TryParse(state, out MissionState missionState);

                        if (!isMissionStateVliad)
                        {
                            continue;
                        }

                        IMission mission = new Mission(codeName, missionState);

                        comanndo.AddMission(mission);

                    }

                    soldiersById[id] = comanndo;

                }
                else if (type == nameof(Spy))
                {

                    int codeNumber = int.Parse(arguments[4]);

                    ISpy spy = new Spy(id, firstName, lastname, codeNumber);

                    soldiersById[id] = spy;
                }
            }

            foreach (var soldier in soldiersById)
            {
                Console.WriteLine(soldier.Value);
            }

        }
    }
}
