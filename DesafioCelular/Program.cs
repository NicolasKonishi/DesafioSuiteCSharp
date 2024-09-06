using System;
using DesafioCelular.models;

class Program
{
    static void Main(string[] args)
    {

        Smartphone nokia = new Nokia("123456789", "Nokia 1100", "Symbian");
        Smartphone iphone = new Iphone("987654321", "iPhone 13", "iOS");


        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
