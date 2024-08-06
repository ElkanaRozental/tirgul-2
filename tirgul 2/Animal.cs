using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirgul_2
{
    public class Animal
    {
        protected string species { get; set; }
        public string GetSpecies()
        {
            return species;
        }
        public void SetSpecies(string species)
        { this.species = species; }
    }
}
