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
            private const string path = "D:\\Generated HTML\\myHTML.html";


            public void CreatHTML(StringBuilder data)
            {
                File.AppendAllText(path, data.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a title for the website.");
            string dynamicTitle = Console.ReadLine();
            Console.WriteLine("Enter the first item in the list.");
            string dynamicList1 = "<li>" + Console.ReadLine() + "</li>";
            Console.WriteLine("Enter the second item in the list.");
            string dynamicList2 = "<li>" + Console.ReadLine() + "</li>";
            Console.WriteLine("Enter the last item in the list.");
            string dynamicList3 = "<li>"+ Console.ReadLine()+"</li>";

            StringBuilder html = new StringBuilder();
            string titleOpen = "<h1>";
            string titleClose = "</h1>";
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string ulOpen = "<ul>";
            string ulClose = "</ul>";

            html.Append(bodyOpen);
            html.Append(titleOpen);
            html.Append(dynamicTitle);
            html.Append(titleClose);
            html.Append(ulOpen);
            html.Append(dynamicList1);
            html.Append(dynamicList2);
            html.Append(dynamicList3);
            html.Append(ulClose);
            html.Append(bodyClose);

            FileWriter file = new FileWriter();
            file.CreatHTML(html);
        }
    }
}
