using System;
 
namespace cSharp
{
    class Program
    {
      static int i,n,sum=0;
       
      public static void Main(String[] args)
        { 
 
         Console.WriteLine("Enter number for summing of numbers");
         int a=int.Parse(Console.ReadLine());
 
         for(i=1;i<=a;i++)
         { 
           Console.WriteLine("Number {0}:",i);
           n=int.Parse(Console.ReadLine());
         sum=sum+n;
         }
         
         Console.WriteLine("The Sum of abve numbers is"+"= "+sum);
         }
    }    
 
}