using System;

namespace introduction 
{
    class AgeCalculator 
    {

        public void Calculator(int age)

        {
            if(age< 18) 
            {
                 Console.WriteLine("Go home please!");
            }
            else if(age< 40)
            {
                Console.WriteLine("Yeah... you can come throuuuuuugh!!");
            }
            else if(age< 65)
            {
                Console.WriteLine("Two drink's max...");
            }
            else
            {
                Console.WriteLine("I dont know 'bout you...");
            }

        }

    }


}