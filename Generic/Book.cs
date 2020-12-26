using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Book<T>
    {
        string name;
        T price;
        public string Name { get; set; }
        public T Price { get; set; }
        public void Show()
        {
            Console.WriteLine($"Название книги {Name} и цена {Price}");
        }
    }
}
