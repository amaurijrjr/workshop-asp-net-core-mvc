using System;

namespace ProjetoAspNetCore.Services.Exceptions
{
    public class IntegratyException : ApplicationException
    {
        public IntegratyException(string message) : base(message)
        {
        }
    }
}
