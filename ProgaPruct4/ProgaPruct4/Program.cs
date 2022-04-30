using System;
using System.Linq;


namespace ProgaPruct4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(1);
            object[] Port = new object[20];

            for (int i = 0; i < 10; i++)
            {
                Port[i] = new Ferry(random.Next(1,15));
            }
            for (int i = 10; i < 20; i++)
            {
                Port[i] = new Frigate(random.Next(1,30));
            }

            var PortSortedBySpeed = from s in Port
                                    let ss = (Ship) s
                                    orderby ss.Speed
                                    select s;

            foreach (var item in Port)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================");
            foreach (var item in PortSortedBySpeed)
            {
                Console.WriteLine(item);
            }

        }
    }
}
