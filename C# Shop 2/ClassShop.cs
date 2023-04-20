using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    public class Shop
    {
        // ATTRIBUTI

        private string name;
        private string city;
        private string country;
        private string address;
        private int number;
        private string owner;
        private List<Prodotti> prodotti;

        // COSTRUTTORE

        public Shop(string name, string city, string country, string address, int number, string owner)
        {
            this.name = name;
            this.city = city;
            this.country = country;
            this.address = address;
            this.number = number;
            this.owner = owner;

            this.prodotti = new List<Prodotti>();
        }

        // GETTERS

        public string GetName()
        {
            return this.name;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetCountry()
        {
            return this.country;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public string GetOwner()
        {
            return this.owner;
        }


        // SETTERS

        public void SetCity()
        {
            this.city = city;
        }

        public void SetCountry()
        {
            this.country = country;
        }

        public void SetAddress()
        {
            this.address = address;
        }

        public void SetNumber()
        {
            this.number = number;
        }

        public void SetOwner()
        {
            this.owner = owner;
        }


        // METODI

        public void addProduct(Prodotti nuovoProdotto)
        {
            prodotti.Add(nuovoProdotto);
        }

        public void productToAdd(List<Prodotti> ListProduct)
        {
            foreach (Prodotti newProduct in ListProduct)
            {
                this.prodotti.Add(newProduct);
            }

        }

        public string ShopInfoList()
        {
            string shopInfoList = "Nome negozio: " + this.name + "\n";
            shopInfoList += "Indirizzo: " + this.address + ", " + this.number + "\n";
            shopInfoList += "Città: " + this.city + ", " + this.country + "\n";

            foreach (Prodotti infoProduct in prodotti)
            {
                shopInfoList += infoProduct.ProductInfoList() + "\n";
            }

            shopInfoList += "\n";

            return shopInfoList;
        }


    }
}
