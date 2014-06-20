using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVR.CadCompra.BLL
{
    public class NotFoundException : Exception
    {
        public NotFoundException(Exception innerException)
            : base(innerException.Message, innerException)
        {
            
        }

        public override string Message
        {
            get
            {
                return "Registro não encontrado";
            }
        }
    }
}
