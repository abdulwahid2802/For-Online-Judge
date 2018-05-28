using System;
using System.IO;

namespace OJupload
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            

            while(count++<10)
            {
                int n;
                //int m;
                Random r = new Random();
                

                n = r.Next(2, 99999999);

                int range = r.Next(2, 100);

                //Console.WriteLine(n + " " + m);


                //int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[10];
                int sumEven = 0, sumOdd = 0;
                for(int i=0;i<10;i++)
                {
                    arr[i] = r.Next(-100, 100);
                    if (arr[i] % 2 == 0)
                        sumEven += arr[i];
                    else
                        sumOdd += arr[i];
                }

                using (StreamWriter inPut = new StreamWriter("..//" + count + ".in"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        inPut.Write(arr[i] + " ");
                        Console.Write(arr[i] + " ");
                    }
                    
                }



                using (StreamWriter outPut = new StreamWriter("..//" + count + ".out"))
                {

                    
                    outPut.WriteLine(sumEven);
                    outPut.WriteLine(sumOdd);
                    Console.WriteLine(sumEven);
                    Console.WriteLine(sumOdd);
                }

            }

            Console.Read();
        }
    }
}
