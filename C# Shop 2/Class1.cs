using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    public class Bevande : Prodotti
    {

        //ATTRIBUTI

        private float litri;
        private float ph;
        private string sorgente;
        private string marca;
        private string tipo;
        private string materialeBottiglia;


        //COSTRUTTORE

        public Bevande(string nomeBevanda, string categoriaBevanda, string descrizioneBevanda, int prezzoBevanda, float litri, float ph, string sorgente, string marca, string tipo, string materialeBottiglia) : base(nomeBevanda, categoriaBevanda, descrizioneBevanda, prezzoBevanda)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            this.marca = marca;
            this.tipo = tipo; // (Minerale, Frizzante...)
            this.materialeBottiglia = materialeBottiglia;

        }
        

        //GETTERS

        public float GetLitri()
        {
            return this.litri;
        }

        public float GetPh()
        {
            return this.ph;
        }

        public string GetSorgente()
        {
            return this.sorgente;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public string GetMaterialeBottiglia()
        {
            return this.materialeBottiglia;
        }


        // METODI

        public void Bevi()
        {
            float litriDaBere = 0.5f;
            Console.WriteLine("Glu glu glu...");
            this.litri = litri - litriDaBere;
            Thread.Sleep(5000);
            Console.WriteLine("Numero litri dopo aver bevuto: " + this.litri);
        }

        public float Riempi()
        {
            float litriDaRiempire = 0;

            Console.WriteLine("Di quanti litri vuoi riempire?");
            litriDaRiempire = float.Parse(Console.ReadLine());
            Console.WriteLine("*Riempie la bottiglia*");
            float litriFinali = this.litri + litriDaRiempire;
            Thread.Sleep(5000);
            if(litriFinali > this.litri)
            {
                Console.WriteLine("Hai versato tutto fuori!");
            }
            else if (litriFinali == this.litri)
            {
                Console.WriteLine("Bottiglia riempita!");
            }

            this.litri = litriFinali;
            return this.litri;
        }








    }
}
