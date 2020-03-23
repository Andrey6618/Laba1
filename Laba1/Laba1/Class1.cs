using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class Class1
    {

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int kol;
        public int Kol
        {
            get { return kol; }
            set { kol = value; }

        }
        public float stoimost;
        public float Stoimost
        {
            get { return stoimost; }
            set { stoimost = value; }

        }



        public void zap()
        {
            Console.WriteLine("Наименование: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Количество: ");
            kol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость: ");
            stoimost = Convert.ToInt32(Console.ReadLine());

        }
        public void viv()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Количество: " + Kol);
            Console.WriteLine("Стоимость: " + Stoimost);
        }



    }
}
