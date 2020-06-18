using System;

namespace introduction

{

    public class Personal
    {
        private string name;

        private string sign;

        private string interests;

        private int age;

        private int stresslevel;


        public void deetz()
        {

            name = "Char";
            sign = "Libra";
            interests = "Coding";
            age = 36;
            stresslevel = 1;

            Console.WriteLine($"Hey! My name is {name}.");
            Console.WriteLine($"My star sign is {sign}, the best one might I add : )");
            Console.WriteLine($"I have many interests, one of fav's is {interests}.");
            Console.WriteLine($"Although I am getting late in the day at age {age}, I am still young at heart.");
            Console.WriteLine($"Today has been fairly easy going, so my stress-level is only {stresslevel}. Good news!");


        }  



    }
}