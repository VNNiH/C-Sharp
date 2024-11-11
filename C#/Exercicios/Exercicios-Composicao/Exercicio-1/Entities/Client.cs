using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        // Construtor padrão
        public Client()
        {
        }

        // Construtor com todos os atributos
        public Client(string name, string email, DateTime birthday)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"Birthday: {Birthday.ToShortDateString()}");
            return sb.ToString();
        }
    }
}
