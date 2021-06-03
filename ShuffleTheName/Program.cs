using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

//namespace My_Awesome_Program
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(NameShuffle("Donald Trump"));
//        }

//        public static string NameShuffle(string str)
//        {
//            string[] fullname = str.Split(" ");
//            string reversedName = string.Join(" ", fullname.Reverse());
//            return reversedName;
//        }
//    }
//}


namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameShuffle("Donald Trump"));
        }

        public static string NameShuffle(string str)
        {
            string[] fullname = str.Split(" ");
            string firstname = fullname.First();
            string lastname = fullname.Last();

            string reversedName = lastname + " " + firstname;
            return reversedName;
        }
    }
}