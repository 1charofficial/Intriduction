using System;

namespace introduction
{

    public class PhoneNumber 
    {

        public String getNumber()
        {
            int n;
            int[] array = new int[26];
            
            
    
            
            
            Console.WriteLine($"Your age check says you are {userInput}. {hello}");


            // myAge.Calculator(Int32.Parse(userInput));


            Console.Write("Please enter your phone number: ");
            String userNum = Console.ReadLine();
            return userNum;

            if (userNum == "")
            {
                Console.WriteLine("great");
            } else 
            {
                Console.WriteLine("bad");
            }


            //Console.WriteLine();



        }

}

}
//Console.Write("Please enter your age: ");
            // string userInput = Console.ReadLine();
            // //OR myAge.Calculator(Convert.ToInt32(userInput)); To convertthe userInput(string) to function
            // //intake(int).


/**
 * Write a function that accepts an array of 11 integers (between 0 and 9), that returns 
 a string of those numbers in the form of a phone number.
 * 
 * For the UK - 07000 000 000
 * 
 * For the US - (123) 456-7890
 */