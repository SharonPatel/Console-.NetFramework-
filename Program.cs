using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFSharonPatel
{
    class Program
    {
        static void Main(string[] args)
        {
           

            bool check = false; //used for do While Condition
            var choice1 = 0;  //Taking choice for Main Menu
            do
            {
                try
                {
                    //Main Menu
                    Console.WriteLine("==================================================================================================================\n\n");
                    Console.WriteLine("Welcome Please Choose a Command");
                    Console.WriteLine("Press 1 to View all Authors");
                    Console.WriteLine("Press 2 to Add Authors");
                    Console.WriteLine("Press 3 to Update Authors");
                    Console.WriteLine("Press 4 to Exit");

                    choice1 = Convert.ToInt32(Console.ReadLine());
                   


                    switch (choice1)
                    {
                        case 1:

                            Methods.getAllAuthors();
                                break;
                        case 2:

                            Methods.AddAuthors();
                            break;

                        case 3:

                            Methods.updateAuthor();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;


                    }




                }
                catch (FormatException)
                {

                    Console.WriteLine("InValid Input! Please Enter correct Data to processed");
                }
            } while (!check);
        }
    }
}
