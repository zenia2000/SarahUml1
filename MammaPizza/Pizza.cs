using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammaPizza
{
    public class Pizza
    {
        //instance for pizza
        private string _name;
        private double _price;
        private int _id;
        private int _size;

        public Pizza(string name, double price, int id, int size)
        {
            Name = name;
            Price = price;
            _id = id;
            Size = size;
        }
    
        public string  Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        
        
        
    }
}
