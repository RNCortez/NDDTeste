using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Exceptions
{
    public class ApiException : Exception
    {
        public string Mensagem { get; set; }
        public ApiException(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
