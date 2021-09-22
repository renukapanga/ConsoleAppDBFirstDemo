using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDBFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ibmEntities())
            {
                var query = from b in db.Persons                           
                            orderby b.name
                            select b;
                Console.WriteLine("All Persons in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.personid + "" + item.name + "" + item.city);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
}
