using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1: Coca Cola 150 ml (2.50 euro)");
            Console.WriteLine("2: Insalata di pollo (5.20 euro)");
            Console.WriteLine("3: Pizza Margherita (10.00 euro)");
            Console.WriteLine("4: Pizza 4 Formaggi (12.50 euro)");
            Console.WriteLine("5: Pz patatine fritte (3.50 euro)");
            Console.WriteLine("6: Insalata di riso (8.00 euro)");
            Console.WriteLine("7: Frutta di stagione (5.00 euro)");
            Console.WriteLine("8: Pizza fritta (5.00 euro)");
            Console.WriteLine("9: Piadina vegetariana (6.00 euro)");
            Console.WriteLine("10: Panino Hamburger (7.90 euro)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("================================");

            List<string> menu = new List<string>();
            List<double> prezzi = new List<double>();
            List<string> scelte = new List<string>();

            menu.Add("Coca Cola 150 ml");
            menu.Add("Insalata di pollo");
            menu.Add("Pizza Margherita");
            menu.Add("Pizza 4 Formaggi");
            menu.Add("Pz patatine fritte");
            menu.Add("Insalata di riso");
            menu.Add("Frutta di stagione");
            menu.Add("Pizza fritta");
            menu.Add("Piadina vegetariana");
            menu.Add("Panino Hamburger");

            prezzi.Add(2.50);
            prezzi.Add(5.20);
            prezzi.Add(10.00);
            prezzi.Add(12.50);
            prezzi.Add(3.50);
            prezzi.Add(8.00);
            prezzi.Add(5.00);
            prezzi.Add(5.00);
            prezzi.Add(6.00);
            prezzi.Add(7.90);
            // le due liste sono collegate tra di loro tramite l'indice

            int scelta = 0;
            double totale = 0;

            while (scelta != 11)
            {
                Console.WriteLine("\nInserisci il prodotto che desideri ordinare: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta != 11)
                {
                    scelte.Add(menu[scelta - 1]);
                    totale += prezzi[scelta - 1];
                    // -1 per trasformare la scelta dell'utente in indice valido per le liste
                }
            }

            Console.WriteLine("Hai ordinato: ");
            foreach (string s in scelte)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nTotale: " + totale + " euro");
            Console.ReadKey();
        }
    }
}
