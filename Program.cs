using System;
using HRM;
namespace HrManagejjmentSystem
{
    class Program
    {
      
        static void Main(string[] args)
        {

            
            string username,password;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("==========================================Welcome To HR Management System==============================================\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter id and password");
            username = Console.ReadLine();
            password = Console.ReadLine();
            if(username=="bhavika" && password=="pass@123")
            {
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("===============================================Enter Your Choice========================================================\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                String Continue = "yes";
                while (Continue == "yes")
                {
                    Console.WriteLine("\t\t\t\t1. Add Employee\n \t\t\t\t2. Delete Employee\n \t\t\t\t3. Update details of  Employee\n \t\t\t\t4. Search employees by name / id / department\n \t\t\t\t5. Search the list of employee for the given department\n \t\t\t\t6. Count of Employee Department Wise\n ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\tPlease enter your choice\t\t\t\t\t");
                int choice = Convert.ToInt32(Console.ReadLine());
                int id ;
                string dep;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("**********************************************************************************************************************");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            
                    switch (choice)
                    {
                        case 1:

                            string Employee, role, emailid, mobileno;
                            Console.WriteLine("\t\t\t\tEnter Id Employee Department Role EmailId Mobileno");
                            id = Convert.ToInt32(Console.ReadLine());
                            Employee = Console.ReadLine();
                            dep = Console.ReadLine();
                            role = Console.ReadLine();
                            emailid = Console.ReadLine();
                            mobileno = Console.ReadLine();

                            Class1.ADD(id, Employee, dep, role, emailid, mobileno);

                            break;


                        case 2:
                            Console.WriteLine("\t\t\t\tEnter Employee Id");
                            id = Convert.ToInt32(Console.ReadLine());
                            Class1.DELETE(id);
                            break;


                        case 3:
                            Console.WriteLine("\t\t\t\tEnter Employee Id");
                            id = Convert.ToInt32(Console.ReadLine());
                            Class1.UPDATE(id);

                            break;


                        case 4:

                            Class1.SEARCH();
                            break;


                        case 5:
                            Console.WriteLine("\t\t\t\tEnter Department");
                            dep = Console.ReadLine();
                            Class1.LIST(dep);
                            break;

                        case 6:
                            Class1.CountByDepartment();
                            break;

                        default:
                            Console.WriteLine("\t\t\t\tPlease Enter valid Choice ");

                            break;

                    }


                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine("*********************************************************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;


                    Console.WriteLine("Want To Continue?");
                    Continue = Console.ReadLine();
                }

            }


            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter correct id and password");
            }
            
        }
    }
}
