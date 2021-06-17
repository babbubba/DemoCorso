using Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining
{
    public class FeatheredAnimalModel : AnimalModel, IFeathered
    {
        public bool CanFly { get; set; }

        public override string AnimalCall()
        {
            return "cip!";
        }
    }
}
