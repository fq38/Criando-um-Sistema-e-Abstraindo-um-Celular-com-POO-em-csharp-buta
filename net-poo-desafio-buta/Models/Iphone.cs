using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_poo_desafio_buta.Models
{
    public class Iphone : Smartphone
    {
        private string memoria;

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

       


        // TODO: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            string texto = $"instalando o aplicativo {nomeApp} no iphone";
            Console.WriteLine(texto);
        }
    }
}
