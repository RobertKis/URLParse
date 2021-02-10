using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urlParse.Models;

namespace urlParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = @"https://example.com/page?id=35&name=Harry%20Hacker&token=FA33CD1AA2C345AF&session_id=72AC43F2-F22E-4554-9CAB-42D893EAFCCF&lang=sv-SE";
            Console.WriteLine("Please insert the URL");
            string url = Console.ReadLine();
            Url data = new Url(url);

            Console.WriteLine($"{ data.LastName}, {data.FirstName} - {data.Language}");
        }
    }
}
