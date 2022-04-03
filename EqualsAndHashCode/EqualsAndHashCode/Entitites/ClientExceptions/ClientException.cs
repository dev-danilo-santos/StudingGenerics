using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAndHashCode.Entitites.ClientExceptions
{
    internal class ClientException : ApplicationException
    {
        public ClientException(string message) : base(message)
        {
        }
    }
}
