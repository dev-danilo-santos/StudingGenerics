using EqualsAndHashCode.Entitites.ClientExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAndHashCode.Entitites
{
    internal class Client : IComparable
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public int Age { get; set; }

        public Client(string name, string cpf)
        {
            Name = name;
            Cpf = cpf.Replace(".","").Replace(" ","").Replace("-","").Trim();

        }

        public Client(string name, string cpf, int age) : this(name, cpf)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Cpf}";
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                throw new ArgumentException("Error, this object not is a Client!");
            }
            Client other = obj as Client;
            return Cpf.Equals(other.Cpf);
        }

        public override int GetHashCode()
        {
            return Cpf.GetHashCode();
        }

        public int CompareTo(object? obj)
        {
           if(!(obj is Client))
            {
                throw new ArgumentException("Error! the object not is a Client! ");
            }
            Client other = obj as Client;

            return Age.CompareTo(other.Age);
        }

        public Client Older(Client other)
        {
            Client aux;
            if (this.CompareTo(other) > 0)
            {
                return this;
            } 
            else if (this.CompareTo(other) < 0) 
            {
                return other;
            }
            throw new ClientException("These customers are the same age.");
        }

    }
}
