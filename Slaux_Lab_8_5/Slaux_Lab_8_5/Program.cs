using System;

namespace Slaux_Lab_8_5
{
    class Program
    {
     
        class Applicant
        {
            public string firstName;
            public string lastName;
            public string dateOfBirth;
            public string address;
            public string city;
            public string state;
            public int zip;
            public string phoneNumber;
            public string email;
            public bool isSubmitted;
            public bool isAccepted;

            public void Submit()
            {
                Console.WriteLine("Application has been submitted!");
                isSubmitted = true;
            }
            public void Accept()
            {
                Console.WriteLine("Application accepted!");
                isAccepted = true;
            }
        }


        class HouseHunter : Applicant
        {
            string jobTitle;
            int annualIncome;
            string buyBy;
            int numOfBeds;
            int numOfBaths; 
            public HouseHunter(string firstName, string lastName, string dateOfBirth, string address, string city,
                string state, int zip, string phoneNumber, string email, string jobTitle, int annualIncome, 
                string buyBy, int numOfBeds, int numOfBaths)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.dateOfBirth = dateOfBirth;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.jobTitle = jobTitle;
                this.annualIncome = annualIncome;
                this.buyBy = buyBy;
                this.numOfBeds = numOfBeds;
                this.numOfBaths = numOfBaths;
            }
            public void Accept()
            {
                isAccepted = true;
                Console.WriteLine("Congradulations "+ firstName +"! You've been accepted to Dream House Hunters!");
            }
        }

        class ParadiseIsland : Applicant
        {
            public string gender;
            public string nameOfSO;
            public int yearsDating;
            public ParadiseIsland(string firstName, string lastName, string dateOfBirth, string address, string city,
                string state, int zip, string phoneNumber, string email, string gender, string nameOfSO, int yearsDating)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.dateOfBirth = dateOfBirth;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.gender = gender;
                this.nameOfSO = nameOfSO;
                this.yearsDating = yearsDating;
            }

            
            public void Accept()
            {
                isAccepted = true;
                Console.WriteLine("Condradulations " + firstName +"! You've been accepted to Paradise Island!");
            }
        }

        class AboveDeck : Applicant
        {
            public string nationality;
            public int yearsBoating;
            public AboveDeck(string firstName, string lastName, string dateOfBirth, string address, string city,
                string state, int zip, string phoneNumber, string email, int yearsBoating, string nationality)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.dateOfBirth = dateOfBirth;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.yearsBoating = yearsBoating;
                this.nationality = nationality;
            }
            public void Accept()
            {
                isAccepted = true;
                Console.WriteLine("Congradulations " + firstName + "! You've been accepted to Above Deck!");
            }
        }
        static void Main(string[] args)
        {

            HouseHunter omarSmith = new HouseHunter("Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angles", 
                "California", 90001, "888-233-1234", "Omar.smith@hotmail.com", "Full stack Web Developer", 
                100000, "6 months", 3, 3);
            omarSmith.Submit();
            omarSmith.Accept();

            ParadiseIsland pattiJohnson = new ParadiseIsland("Patti", "Johnson", "5/4/1994", "222 Love Rd", "Los Angles", 
                "California", 90001, "988-444-1234", "pati.johnson@hotmail.com", "Female", "Carl", 2);
            pattiJohnson.Submit();
            pattiJohnson.Accept();

            AboveDeck captainLee = new AboveDeck("Captain", "Lee", "7/12/1964", "311 Bravo Way", "Los Angles",
                "Californa", 90001, "711-333-1234", "captain@gmail.com", 20, "American");

            captainLee.Submit();
            captainLee.Accept();



        }
    }
}
