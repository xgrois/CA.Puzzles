using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //        |         |         | 
            //        |         |         | 
            //       |1|        |         | 
            //      | 2 |       |         | 
            //     |  3  |      |         |  
            //  --------------------------------
            //        A         B         C

            Hanoi(3, 'A', 'B', 'C');
        }


        static void Hanoi(int n, char src, char aux, char dst)
        {
            if (n > 0)
            {
                Hanoi(n - 1, src, dst, aux);
                Console.WriteLine($"Move disk {n}: {src} --> {dst}");
                Hanoi(n - 1, aux, src, dst);
            }

        }

    }
}
