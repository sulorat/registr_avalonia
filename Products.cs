using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg
{
    internal class Product
    {
        private string name;
        private string description;
        private int maxQuantity;
        private int quantity;
        private int price;


        private static ObservableCollection<Product> _products = new();
        private static ObservableCollection<Product> _selected = new();

        public Product(string name, string description, int price, int quantity)
        {
            this.name = name;
            this.description = description;
            maxQuantity = quantity;
            this.quantity = quantity;
            this.price = price;
        }


        public int Price
        {
            get => price;
            set => price = value;   
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Quantity
        {
            get => quantity;
            set => maxQuantity = value;
        }


        public static ObservableCollection<Product> Products
        {
            get => _products;
            set => _products = value;
        }



        public static ObservableCollection<Product> SelectedProducts
        {
            get => _selected;
            set => _selected = value;
        }
        

        public Product()
        {
            Products = new ObservableCollection<Product>
            {
                new Product{name = "Bread", description = "Food",Price = 1000, Quantity = 10},
            
                new Product { Name = "Car", Price = 4500, Quantity = 1, description = "Car" },

                new Product{Name = "Cheese", Price = 1000, Quantity = 10, description = "Food"}
            };
        }

    }
}
