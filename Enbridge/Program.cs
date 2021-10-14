using Enbridge.Model;
using Enbridge.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Enbridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string columnName = DataColumnName.first;
                //change to depenedency injection for real project
                var result = new DataService().ShortColumn(columnName);
                Console.WriteLine($"Sort list by {columnName}");
                foreach (var item in result)
                {
                    Console.WriteLine(item.Print());
                }
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                //Log
                throw ex;
            }
        }


    }
}
