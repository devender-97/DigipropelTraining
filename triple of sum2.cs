using System;
namespace cSharp
{
    class Program
    {
        static int a,b,n;
        public static void Main(String[] args)
        {
          
           Console.WriteLine("Enter two numbers");
           a=int.Parse(Console.ReadLine());
           b=int.Parse(Console.ReadLine());
           n=a+b;
           if(a==b){
               Console.WriteLine("triple of the sum  "+n*3);
           }
         else{
           Console.WriteLine("sum of two numbers is "+ n);
         }
          
     }
    }
}