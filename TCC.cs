using System;
/*
   This is a program to calculate the Collatz Conjecture
   written by k0ds
*/  

namespace TCC
{
    class Program 

    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Type in the number you want to use: ");
           int num = Int32.Parse(Console.ReadLine());                    
                for (int i = 0; i < 3;)
                {
                    if (IsOdd(num) == false)
                      {
                       num = num / 2;
                      }
                      else
                      {
                        num = num * 3 + 1;
                       }
                      if (num == 1)
                      {
                         i++;
                      }
                         Console.WriteLine(num);                 
                }

     
        }
    
        public static bool IsOdd(int num)
        {
             if (num%2 == 0)
             {
                 return false;
             }
             else
             {
                 return true;
             }
   

        }

        
    }
}
