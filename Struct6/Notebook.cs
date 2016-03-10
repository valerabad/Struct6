using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct6
{
    struct Notebook
    {
        string model;
        string producer;
        double price;

        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price; 
        }

        public void Show()
        {
            Console.WriteLine("Производитель: {0}\nМодель: {1}\nЦена: {2}", producer, model, price);
        }
    }
}
