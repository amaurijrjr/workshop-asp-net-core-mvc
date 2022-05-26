using System;

namespace ProjetoAspNetCore.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base(message)
        {

        }
    }
}
