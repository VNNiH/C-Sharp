using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Abstratas
{
    //a class Animal serve apenas para modelo para class que vao herda-la, por isso a mesma nao pode ser instanciada
    abstract class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
        //método abstract não tem corpo apenas a assinatura do método
        public abstract void EmitirSom();

    }
}
