using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Simple_Calculator.Classes
{
    public class Calculator { 


        public static  double Calculate(double firstNumber , double secondNumber ,string process)
        {
            double result = 0;
            switch (process)
            {
                case "+": Console.WriteLine("Toplama işlemi başlıyor . . . ");
                    Console.Write(firstNumber + " " + process + " " + secondNumber + " = "); 
                    result = firstNumber + secondNumber; break;
                case "-":
                    Console.WriteLine("Çıkarma işlemi başlıyor . . . ");
                    Console.Write(firstNumber + " " + process + " " + secondNumber + " = ");
                    result = firstNumber - secondNumber; break;
                case "*":
                    Console.WriteLine("Çarpma işlemi başlıyor . . . ");
                    Console.Write(firstNumber + " " + process + " " + secondNumber + " = ");
                    result = (firstNumber * secondNumber); break;
                case "/":
                    Console.WriteLine("Bölme işlemi başlıyor . . . ");
                    Console.Write(firstNumber + " " + process + " " + secondNumber + " = ");
                    result = ( firstNumber / secondNumber); break;
            }

            return result;
        }
    }
}
