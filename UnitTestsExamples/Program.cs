using System;

namespace MyProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static bool Login(string user, string pwd)
        {
            if (user == "user" && pwd == "pwd")
                return true;
            return false;
        }
    }

    public class Customer
    {
        public static string GetCustomerWelcome(string name)
        {
            return "Welcome " + name;
        }
    }
}
