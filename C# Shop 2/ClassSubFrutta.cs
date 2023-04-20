using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    public class Frutta : Prodotti
    {
        //ATTRIBUTI

        private int peso;
        private int numeroPezzi;


        //COSTRUTTORE
        public Frutta(string productName, string productCategory, string productDescription, int productPrice) : base(productName, productCategory, productDescription, productPrice)
        {
            this.peso = peso;
            this.numeroPezzi = numeroPezzi;
        }


        //GETTERS

        public int GetPeso()
        {
            return this.peso;
        }

        public int GetNumeroPezzi()
        {
            return this.numeroPezzi;
        }


        //SETTERS

        public void SetNumeroPezzi(int numeroPezzi)
        {
            if(numeroPezzi > 5)
            {
                Console.WriteLine("Il sacchetto può contenere al massimo 5 pezzi!");
            }

            this.numeroPezzi = numeroPezzi;
        }


        //METODI
        public int Mangia()
        {
            int pezziDaMangiare = 1;
            Console.WriteLine("Chomp chomp...");
            this.numeroPezzi = numeroPezzi - pezziDaMangiare;
            Thread.Sleep(5000);
            Console.WriteLine("Numero pezzi dopo aver mangiato: " + this.numeroPezzi);
            return this.numeroPezzi;
        }

        public float SvuotaSacchetto()
        {
            Console.WriteLine("*Svuota il sacchetto*");
            Thread.Sleep(5000);
            Console.WriteLine("Sacchetto vuoto!");
            this.numeroPezzi = 0;
            return this.numeroPezzi;
        }

        public int RiempiSacchetto()
        {
            int pezziDaInserire = 0;

            Console.WriteLine("Quanti pezzi vuoi inserire?");
            pezziDaInserire = int.Parse(Console.ReadLine());
            Console.WriteLine("*Riempie la bottiglia*");
            int pezziFinali = this.numeroPezzi + pezziDaInserire;
            Thread.Sleep(5000);
            if (pezziFinali > this.numeroPezzi)
            {
                Console.WriteLine("Hai inserito troppi pezzi!");
            }
            else if (pezziFinali == this.numeroPezzi)
            {
                Console.WriteLine("Sacchetto riempito!");
            }

            this.numeroPezzi = pezziFinali;
            return this.numeroPezzi;
        }
    }



}
