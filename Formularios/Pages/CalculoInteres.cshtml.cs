using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Formularios.Pages
{
    public class CalculoInteresModel : PageModel
    {
        decimal vMonto;
        int vcuotas;
        decimal vporcentaje;
        public decimal Monto { get; set; }
        public decimal Cuotas { get; set; }
        public decimal Porcentajes { get; set; }
        public decimal Interes { get; set; }
        public decimal Deuda { get; set; }

        public void OnGet(decimal monto, int cuotas, decimal Porcentaje)
        {

            this.vMonto = monto;
            this.vcuotas = cuotas;
            this.vporcentaje = Porcentaje;

            cualculadora(vMonto, vcuotas, vporcentaje);
        }


        public void cualculadora(decimal vMonto, int vcuotas, decimal vporcentaje)
        {

            // decimal valorcuotas;
            // decimal Cuotasv = vcuotas;
            //Cuotas = 0;
                //vcuotas;
            Porcentajes = vporcentaje;
            Monto = vMonto;

            decimal inter = 0;
            inter = (Monto * Porcentajes) / 100;

            Interes = inter;

            Deuda = (Monto + inter);
            if (vcuotas !=0)
            {
                Cuotas = Deuda / Convert.ToDecimal(vcuotas);
            }
            else
            {
                Cuotas =Convert.ToDecimal(vcuotas);
            }

            //valorcuotas = (Monto + inter) / Cuotasv;

        }

    }
}
