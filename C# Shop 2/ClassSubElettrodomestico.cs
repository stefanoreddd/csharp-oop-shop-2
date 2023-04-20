using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    public class Elettrodomestico : Prodotti
    {

        //ATTRIBUTI

        private string marca;
        private int peso;
        private string anno;


        //COSTRUTTORE
        public Elettrodomestico(string productName, string productCategory, string productDescription, int productPrice, string marca, int peso, string anno) : base(productName, productCategory, productDescription, productPrice)
        {
            this.marca = marca;
            this.peso = peso;
            this.anno = anno;
        }


        //GETTERS

        public string GetMarca()
        {
            return this.marca;
        }

        public int GetPeso()
        {
            return this.peso;
        }

        public string GetAnno()
        {
            return this.anno;
        }


        //SETTERS

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
    }

}
