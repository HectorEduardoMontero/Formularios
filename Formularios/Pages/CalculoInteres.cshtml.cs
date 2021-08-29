using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formularios.Pages
{
    public class CalculoInteresModel : PageModel
    {
        decimal vMonto;
        int vcuotas;
        decimal vporcentaje;
        public decimal Monto { get; set; }
        public int Cuotas { get; set; }
        public decimal Porcentajes { get; set; }
        public decimal Interes { get; set; }
        public decimal Deuda { get; set; }

        public void OnGet( decimal monto,int cuotas,decimal Porcentaje)
        {
        
             this.vMonto = monto;
            this.vcuotas = cuotas;
            this.vporcentaje = Porcentaje;

            cualculadora(vMonto, vcuotas, vporcentaje);
        }


        public void cualculadora(decimal vMonto, int vcuotas, decimal vporcentaje)
        {
          

            Cuotas = vcuotas;
          Porcentajes = vporcentaje;
            Monto = vMonto;

            decimal inter = 0;
            inter = (Monto * Porcentajes) / 100;

            Interes = inter;

            Deuda = (Monto + inter);


        }


        public class Prestamos
        {
              



        }
    }
}
