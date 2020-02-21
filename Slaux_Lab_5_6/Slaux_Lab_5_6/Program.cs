using System;

namespace Slaux_Lab_5_6
{
    class Program
    {
        struct customer
        {
            public int customerID;
            public string firstName;
            public string lastName;
            public int age;
            public bool isMember;
        }
        static void Main(string[] args)
        {
            customer customer1 = new customer();
            customer1.customerID = 1;
            customer1.firstName = "John";
            customer1.lastName = "Young";
            customer1.age = 20;
            customer1.isMember = false;

            customer customer2 = new customer();
            customer2.customerID = 2;
            customer2.firstName = "Rob";
            customer2.lastName = "Old";
            customer2.age = 60;
            customer2.isMember = false;

            customer customer3 = new customer();
            customer3.customerID = 3;
            customer3.firstName = "Sean";
            customer3.lastName = "Laux";
            customer3.age = 29;
            customer3.isMember = true;

            if (customer1.age >= 21)
            {
                Console.WriteLine(customer1.firstName + " " + customer1.lastName +" is old enough to purchase beer!");
                if(customer1.isMember == true)
                {
                    Console.WriteLine("and is a member!");
                }
                else
                {
                    Console.WriteLine("but, they are not a member");
                }
            }
            else
            {
                Console.WriteLine(customer1.firstName + " " + customer1.lastName + " is not old enough to purchase beer");
            }



            if (customer2.age >= 21)
            {
                Console.WriteLine(customer2.firstName + " " + customer2.lastName + " is old enough to purchase beer!");
                if (customer2.isMember == true)
                {
                    Console.WriteLine("and is a member!");
                }
                else
                {
                    Console.WriteLine("but, they are not a member");
                }
            }
            else
            {
                Console.WriteLine(customer2.firstName + " " + customer2.lastName + " is not old enough to purchase beer");
            }



            if (customer3.age >= 21)
            {
                Console.WriteLine(customer3.firstName + " " + customer3.lastName + " is old enough to purchase beer!");
                if (customer3.isMember == true)
                {
                    Console.WriteLine("and is a member!");
                }
                else
                {
                    Console.WriteLine("but, they are not a member");
                }
            }
            else
            {
                Console.WriteLine(customer3.firstName + " " + customer3.lastName + " is not old enough to purchase beer");
            }


        }
    }
}
