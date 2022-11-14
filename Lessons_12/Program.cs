using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lessons_12
{
    internal class Program
    {
        private static String _login;
        private static String _pass;
        private static String _confpass;
        public static string Authorization(string Login, string Password, string ConfirmPassword )
        {
            _login = Login;
            _pass = Password;
            _confpass = ConfirmPassword;
            return _login;
           
        }

       

    }
}












/*
        
      public static void Main(string[] args) { 
       


        string MyString = "Hello World!";
            Console.WriteLine(MyString.PadRight(20, '-'));
        

            Console.WriteLine("Start in singup!");
            
            
            
            Console.WriteLine("(in word) Login:");
            login = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Password:");
            pass = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("ConfirmPassword");
            confpass = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Acount Created Login: " + login);
 
             Console.WriteLine("Login form!");
     
         
                Console.WriteLine("Password Corect");

            Console.WriteLine("You successfully LOGIN!!!");

            Console.ReadKey();
        }
    }


}
   */