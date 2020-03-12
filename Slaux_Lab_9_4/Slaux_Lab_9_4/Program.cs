using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Slaux_Lab_9_4
{
    class Program
    {
        class FileWriter
        {
            //Sets path for HTML file
            private const string path = "D:\\Generated HTML\\myHTML.html"; 


            public void CreatHTML(StringBuilder data)
            {
                File.Delete(path); //Delete because I want to run multiple times
                File.AppendAllText(path, data.ToString()); //takes a path and data and adds it to the file
                //convert to string since we pass it a stringbuilder
            }
        }
        static void Main(string[] args)
        {
            //Getting website title from user
            Console.WriteLine("Enter a title for the website.");
            string dynamicTitle = Console.ReadLine();

            //getting how many itmes in list from user
            Console.WriteLine("How many items in your list?");
            int numOfItems = Convert.ToInt32(Console.ReadLine());
            
            StringBuilder dynamicList = new StringBuilder(); //stringbuilder for dynamic list

            for(int i = 0; i < numOfItems; i++) //I wanted the user to be able to decide how many items they needed
            {
                //loops through and adds the items onto dynamic list one at a time
                dynamicList.Append("<li>");
                Console.WriteLine("Enter the next item in your list");
                dynamicList.Append(Console.ReadLine());
                dynamicList.Append("</li>");
            }

            //All the strings needed to build HTML code
            string titleOpen = "<h1>";
            string titleClose = "</h1>";
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string ulOpen = "<ul>";
            string ulClose = "</ul>";

            //stringbuilder to add all HTML code to
            StringBuilder html = new StringBuilder();
           
            //Adding each item to HTML in order to form proper HTML code
            html.Append(bodyOpen);
            html.Append(titleOpen);
            html.Append(dynamicTitle);
            html.Append(titleClose);
            html.Append(ulOpen);
            html.Append(dynamicList);
            html.Append(ulClose);
            html.Append(bodyClose);

            //Creates the object file to create store the code
            FileWriter file = new FileWriter();
            //calls the createHTML method and passes it our HTML
            file.CreatHTML(html);
        }
    }
}
