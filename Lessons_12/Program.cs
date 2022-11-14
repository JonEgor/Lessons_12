using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lessons_12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            String login;
            String pass;
            String conpass;


           
            Console.WriteLine("Start in singup!");

            Console.WriteLine("(in word) Login:");
            login = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Password:");
            pass = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("ConfirmPassword");
            conpass = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Acount Created Name: " + login);
 
             Console.WriteLine("Login form!");
     
         
                Console.WriteLine("Password Corect");

            Console.WriteLine("You successfully LOGIN!!!");

            Console.ReadKey();
        }
    }


}
