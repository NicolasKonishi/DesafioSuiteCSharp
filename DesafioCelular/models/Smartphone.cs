using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCelular.models { 
 public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        public Smartphone(string numero, string modelo, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
