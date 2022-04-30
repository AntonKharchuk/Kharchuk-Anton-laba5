using System;

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
                Port[i] = new Ferry(random.Next(15));
            }
            for (int i = 10; i < 20; i++)
            {
                Port[i] = new Frigate(random.Next(30));
            }



        }
    }
}
