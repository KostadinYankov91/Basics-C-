using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {

        }

        public void Color(IEgg egg, IBunny bunny)
        {
            while (!egg.IsDone() || bunny.Energy > 0 &&
                   bunny.Dyes.Count > 0)
            {

                if (bunny.Energy >= egg.EnergyRequired && bunny.Dyes.Count > 0)
                {
                    foreach (IDye dye in bunny.Dyes)
                    {
                        dye.Use();
                        egg.GetColored();

                        if (egg.IsDone())
                        {
                            break;
                        }
                        else if (dye.IsFinished())
                        {
                            if (bunny.Dyes.Count <= 0)
                            {
                                break;
                            }
                            continue;
                        }
                    }
                }

            }
        }
    }
}
