using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.JsonClases
{
    public class BeneficiarioInsert
    {
        public int id_beneficiario { get; set; }
        public int NoCuenta { get; set; }
        public int ID_TipoBeneficiario { get; set; }
        public string nombre { get; set; }        
        public int ID_Cliente { get; set; }
    }
}