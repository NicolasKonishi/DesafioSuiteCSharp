using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCelular.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string sistemaOperacional)
            : base(numero, modelo, sistemaOperacional)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}
