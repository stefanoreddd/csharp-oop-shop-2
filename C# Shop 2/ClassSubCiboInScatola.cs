using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    public class CiboInScatola : Prodotti
    {

        //ATTRIBUTI

        private int peso;
        private int marca;


        //COSTRUTTORE

        public CiboInScatola(string productName, string productCategory, string productDescription, int productPrice, int peso, int marca) : base(productName, productCategory, productDescription, productPrice)
        {
            this.peso = peso;
            this.marca = marca;
        }


        //GETTERS

        public int GetPeso()
        {
            return this.peso;
        }

        public int GetMarca()
        {
            return this.marca;
        }


        //SETTERS

        public void SetPeso(int peso)
        {
            if (this.peso > 300)
            {
                Console.WriteLine("Non puoi inserire più di 300g di cibo!");
            }
            else if (this.peso <= 300) 
            {
                Console.WriteLine("Peso modificato!");
            }
            this.peso = peso;
        }


        //METHODS

        public int MangiaCibo()
        {
            int ciboDaMangiare = 1;
            Console.WriteLine("Chomp chomp...");
            this.peso = peso - ciboDaMangiare;
            Thread.Sleep(5000);
            Console.WriteLine("Peso cibo dopo aver mangiato: " + this.peso);
            return this.peso;
        }

        public float SvuotaScatola()
        {
            Console.WriteLine("*Svuota la scatola*");
            Thread.Sleep(5000);
            Console.WriteLine("Scatola vuoto!");
            this.peso = 0;
            return this.peso;
        }

        public int RiempiScatola()
        {
            int ciboDaInserire = 0;

            Console.WriteLine("Quanto cibo (in grammi) vuoi inserire?");
            ciboDaInserire = int.Parse(Console.ReadLine());
            Console.WriteLine("*Riempie la bottiglia*");
            int ciboFinale = this.peso + ciboDaInserire;
            Thread.Sleep(5000);
            if (ciboFinale > this.peso)
            {
                Console.WriteLine("Hai inserito troppo cibo!");
            }
            else if (ciboFinale == this.peso)
            {
                Console.WriteLine("Sacchetto riempito!");
            }

            this.peso = ciboFinale;
            return this.peso;
        }
    }
}
