using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
       // Console.WriteLine("Enter your first number:");
        
        double num1= double.Parse(Console.ReadLine());
        
       // Console.WriteLine("What's function do you want? +,-,*,/");
        
        string sign = Console.ReadLine();
        
       // Console.WriteLine("Enter your second number: ");
        
        double num2= double.Parse(Console.ReadLine());
        
        switch (sign)
        {
            case "+":
            Console.WriteLine(num1+"+"+num2+ "="+(num1+num2));
            break;
            
             case "-":
            Console.WriteLine(num1+"-"+num2+ "="+(num1-num2));
            break;
            
             case "*":
            Console.WriteLine(num1+"*"+num2+ "="+(num1*num2));
            break;
            
             case "/":
             if (num2==0)
             {
                 Console.WriteLine(num1+"/"+num2+"="+"0");
             }
             else
             {
             Console.WriteLine(num1+"/"+num2+ "="+(num1/num2));
             }
            break;
            
            default:
            Console.WriteLine("Error, check mistakes");
            break;
            
        }
        }
    }
}
