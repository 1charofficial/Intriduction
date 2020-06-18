using System;

namespace introduction

{


    class Program
    {
        static void Main(string[] args)
        {
           
            AgeCalculator myAge = new AgeCalculator();
            Console.Write("Please enter your age: ");
            string userInput = Console.ReadLine();
            //OR myAge.Calculator(Convert.ToInt32(userInput)); To convertthe userInput(string) to function
            //intake(int).

            string hello = "Hello!";
            Console.WriteLine($"Your age check says you are {userInput}. {hello}");
            myAge.Calculator(Int32.Parse(userInput));
            Encapsulation example = new Encapsulation();
            example.name = "char";
            example.salary = 200000;
            example.information();
            Personal info = new Personal();
            info.deetz();
            PhoneNumber digits = new PhoneNumber();
            digits.getNumber();


            Mathematics maths = new Mathematics();
            double addMePlease = maths.Addition(10, 2.5);
            double subtractMePlease = maths.Subtraction(10,23.5);
            double multiMePlease = maths.Multiplication(10,21);
            double divideMePlease = maths.Division(10,29);
            Console.WriteLine(addMePlease);
            Console.WriteLine(subtractMePlease);
            Console.WriteLine(multiMePlease);
            Console.WriteLine(divideMePlease);
            Encapsulation person = new Encapsulation();
            string person = "char";
            double person = 200000;
            person.information();
            

            
            


            ////-------------------------------------

            //Below is an example of how you can substitute the doubles for 'decimal and float'.
            //We would replace 'double' with 'decimal and float' in the 'multiMePlease' and 'divideMePlease'
            //methods in the Mathematics Class.

            // double addMePlease = maths.Addition(10, 2.5);
            // double subtractMePlease = maths.Subtraction(10,23.5);
            // decimal multiMePlease = maths.Multiplication(10m,27m);
            // float divideMePlease = maths.Division(10f,29f);
             


            //encapsulation ---
            //private - limiting access to the same class
            //public - free for all - any object can access the data
            //protected - limits access to the same class OR descendants
            //internal - c# only for OOP - limits access to a namespace (asssembly)
        }
    }
}
