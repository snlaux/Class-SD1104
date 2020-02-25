using System;
using System.Collections.Generic;
using System.Text;

namespace Slaux_Lab_7_4
{
    class Program
    {

        class DatingProfile
        {
            public string firstName;
            public string lastName;
            public int age;
            public string gender;
            public string bio;
            private List<Message> myMessages;

            public DatingProfile(string firstName, string lastName, int age, string gender)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.gender = gender;
                myMessages = new List<Message>();
            }
            public void WriteBio(string input)
            {

                bio = input;
            }

            public void DisplayBio()
            {
                Console.WriteLine(firstName + " " + lastName + " Bio: " + bio);
            }
            public void ReadMessage()
            {
                foreach (Message message in myMessages)
                {
                    if (message.isRead == false)
                    {
                        Console.WriteLine("Title: " + message.messageTitle);
                        Console.WriteLine(message.messageData);
                        message.isRead = true;
                    }
                }
            }


            public void AddMessage(Message message)
            {
                myMessages.Add(message);
            }



            public void SendMessage(string messageTitle, string messageData, DatingProfile toProfile)
            {
                Message message = new Message(this, messageTitle, messageData);
                toProfile.AddMessage(message);
            }
        }   



            class Message
            {
                public DatingProfile sender;
                public string messageTitle;
                public string messageData;
                public bool isRead;

                public Message(DatingProfile sender, string messageTitle, string messageData)
                {
                    this.sender = sender;
                    this.messageTitle = messageTitle;
                    this.messageData = messageData;
                    isRead = false;
                }
            }




            static void Main(string[] args)
            {
                DatingProfile sean = new DatingProfile("Sean", "Laux", 29, "Male");
                sean.WriteBio("Loves to code");

                DatingProfile sarah = new DatingProfile("Sarah", "Pratt", 25, "Female");
                sarah.WriteBio("Loves coders");

                DatingProfile ruth = new DatingProfile("Ruth", "Rudeperson", 99, "Female");
                ruth.WriteBio("HAHA, sure loves coders!");

                sean.DisplayBio();
                ruth.DisplayBio();
                sarah.DisplayBio();



                sean.SendMessage("Hello Ruth", "What do you love about coders?", ruth);
                ruth.ReadMessage();
                ruth.SendMessage("Lol you're a nerd", "I was being ironic, coders are lame", sean);
                sarah.SendMessage("Hi!", "Hey Sean, what languages do you know?", sean);
                
                sean.ReadMessage();
            }
        
    }
}

