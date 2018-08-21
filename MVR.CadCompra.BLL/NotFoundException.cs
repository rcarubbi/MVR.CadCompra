using System;

namespace MVR.CadCompra.BLL
{
    public class NotFoundException : Exception
    {
        public NotFoundException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public override string Message => "Registro não encontrado";
    }
}