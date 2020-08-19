using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFSharonPatel
{
    class Methods
    {

      
        public static void getAllAuthors()
        {
            var context = new BooksDBEntities();
            var selectQuery = (from a in context.Authors
                               select a).ToList();

            Console.WriteLine("==================================================================================================================\n\n");
            foreach (var select in selectQuery)
            {
                Console.WriteLine($"{select.AuthorID,10} {select.FirstName,-20} " +
                    $"{select.LastName,-20 } {select.Phone, -20} {select.Address,-20}" +
                    $"{select.City,-20} {select.State,-20} ");
            }
        }

        public static void AddAuthors()
        {
            using (var context = new BooksDBEntities())
            {
                try
                {
                    var aut = new Author();


                    Console.WriteLine("Enter Author FirstName:");
                    var input = Console.ReadLine();


                    Console.WriteLine("Enter Author LasttName:");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("Enter Author PhoneDetails:");
                    string inputPhone = Console.ReadLine();

                    Console.WriteLine("Enter Address:");
                    string inputAddress = Console.ReadLine();

                    Console.WriteLine("Enter City:");
                    string inputCity = Console.ReadLine();

                    Console.WriteLine("Enter State:");
                    string inputState = Console.ReadLine();


                    aut.FirstName = input;
                    aut.LastName = input1;
                    aut.Phone = inputPhone;
                    aut.Address = inputAddress;
                    aut.City = inputCity;
                    aut.State = inputState;


                    context.Authors.Add(aut);
                    Console.WriteLine("Addedd Successfully");

                    context.SaveChanges();


                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e);
                   
                    throw;
                }
                }
        }

        public static void updateAuthor()
        {
            using (var context = new BooksDBEntities())
            {
                try
                {
                   

                    //var try1= new Author();

                    Console.WriteLine("Enter Id to search:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var upd = context.Authors.Find(id);

                   
                        if (upd != null)
                        {
                            Console.WriteLine("Enter Author FirstName");
                            string fname = Console.ReadLine();


                            Console.WriteLine("Enter Author LastName");
                            string lname = Console.ReadLine();

                            Console.WriteLine("Enter Phone Details:");
                            string phone = Console.ReadLine();

                            Console.WriteLine("Enter Address:");
                            string address = Console.ReadLine();

                            Console.WriteLine("Enter City:");
                            string city = Console.ReadLine();

                            Console.WriteLine("Enter State:");
                            string state = Console.ReadLine();



                            upd.FirstName = fname;
                            upd.LastName = lname;
                            upd.Phone = phone;
                            upd.Address = address;
                            upd.City = city;
                            upd.State = state;
                        
                        Console.WriteLine("Inserted Successfully");

                      }
                        else
                        {
                             Console.WriteLine("Id doesn't exist"); 
                        }
                        context.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
      
    }
}
