using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formularios.Pages
{
    public class CajeroAutomaticoModel : PageModel
    {

        public List<string> Bancos = new List<string>()
        {
            "ABC", "RESERVAS", "BHD","APAP",
        };
        public int Bi_1000 { get; set; }
        public int Bi_500 { get; set; }
        public int Bi_100 { get; set; }
        public int Calculo_1000 { get; set; }
        public int Calculo_500 { get; set; }
        public int Calculo_100 { get; set; }
        public int Disponible { get; set; }
        public string Banco { get; set; }
        public int _Monto { get; set; }
        public string Mensajeerror { get; set; }
 



        public void OnGet(int Monto,string Banco )
        {


            //if (Monto >= 1000)
            //{
            //    Bi_1000 = Monto / 1000;
            //    Monto = Monto - (Bi_1000 * 1000);
            //}

            //if (Monto >= 500)
            //{
            //    Bi_500 = Monto / 500;
            //    Monto = Monto - (Bi_500 * 500);

            //}

            //if (Monto >= 100)
            //{
            //    Bi_100 = Monto / 100;
            //}

            //Mensajeerror = "";

            if (Banco == "ABC" && Monto > 10000)
            {
                Mensajeerror = "Solo puede retirar 10000";

            }
      
           else if (Banco == "BANRESERVAS" || Monto > 2000)
            {

                Mensajeerror = "Solo pueden retirar 2000";

            }

            else
            {
                if (Monto >= 1000)
                {
                    Bi_1000 = Monto / 1000;
                    Monto = Monto - (Bi_1000 * 1000);
                }

                if (Monto >= 500)
                {
                    Bi_500 = Monto / 500;
                    Monto = Monto - (Bi_500 * 500);

                }

                if (Monto >= 100)
                {
                    Bi_100 = Monto / 100;
                }

                Mensajeerror = "Monto Retirables";
            }

        }









    }
}
