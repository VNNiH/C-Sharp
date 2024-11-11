using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio2
{
    class Departament
    {
        public string Name { get; set; }

        public Departament() 
        {
        }
        public Departament(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
