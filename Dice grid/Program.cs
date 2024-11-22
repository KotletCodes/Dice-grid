using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_grid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] shake(int[,] a)
            {
                Random random = new Random();
                for (int x = 0; x < 4; x++)
                {

                    for (int i = 0; i < 4; i++)
                    {
                        int place = random.Next(1, 6);
                        a[x, i] = place;



                    }
                }
                return a;



            }
            int[,] list = new int[4, 4];
            bool checkrow = false;
            int sum = 0;
            list = shake(list);
            Console.WriteLine("your new shaken values are as follows:");
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < 4; i++)
                {
                    string temp = list[i, x].ToString();
                    Console.Write(temp + "\t");
                    sum = sum + list[i, x];




                }

            }
            int count = 0;
            int even = 0;
            
            if (list[0, 0] % 2 == 0 && list[0, 3] % 2 == 0 && list[3, 0] % 2 == 0 && list[3, 3] % 2 == 0)
            {

                sum += 20;
            }
            if (list[0, 0] % 2 != 0 && list[0, 3] % 2 != 0 && list[3, 0] % 2 != 0 && list[3, 3] % 2 != 0)
            {

                sum += 20;
            }
            if (list[0, 0] % 2 == 0 && list[1,1] % 2 == 0 && list[2, 2] % 2 == 0 && list[3, 3] % 2 == 0)
            {

                sum += 20;
            }
            if (list[0, 0] % 2 != 0 && list[1, 1] % 2 != 0 && list[2, 2] % 2 != 0 && list[3, 3] % 2 != 0)
            {

                sum += 20;
            }
            if (list[0, 3] % 2 == 0 && list[1, 2] % 2 == 0 && list[2, 1] % 2 == 0 && list[3, 0] % 2 == 0)
            {

                sum += 20;
            }
            while( count != 4)
            {

                even = 0;
                for (int x = 0; x < 4; x++)
                {
                    if (list[count, x] % 2 == 0)
                    {
                        even++;
                    
                    }
                    
                
                
                }
                if (even == 4)
                {
                    sum += 20;
                
                }
                count++;
            
            
            
            }
            int odd = 0;
            count = 0;
            while (count != 4)
            {

                odd = 0;
                for (int x = 0; x < 4; x++)
                {
                    if (list[count, x] % 2 != 0)
                    {
                        odd++;

                    }



                }
                if (odd == 4)
                {
                    sum += 20;

                }
                count++;



            }
            odd = 0;
            count = 0;
            while (count != 4)
            {

                odd = 0;
                for (int x = 0; x < 4; x++)
                {
                    if (list[x, count] % 2 != 0)
                    {
                        odd++;

                    }



                }
                if (odd == 4)
                {
                    sum += 20;

                }
                count++;



            }
            even = 0;
            count = 0;
            while (count != 4)
            {

                odd = 0;
                for (int x = 0; x < 4; x++)
                {
                    if (list[count, x] % 2 == 0)
                    {
                        even++;

                    }



                }
                if (even == 4)
                {
                    sum += 20;

                }
                count++;



            }











            Console.WriteLine("your sum is " + sum);


            Console.ReadKey();

        }
    }
}
