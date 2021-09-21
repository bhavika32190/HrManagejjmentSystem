using System;
using HRM;
namespace HrManagejjmentSystem
{
    class Program
    {
      
        static void Main(string[] args)
        {

            
            string username,password;
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter id and password");
            username = Console.ReadLine();
            password = Console.ReadLine();
            if(username=="bhavika" && password=="pass@123")
            {
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("==========================================Welcome To HR Management System==============================================\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\t\t1. Add Employee\n \t\t\t\t2. Delete Employee\n \t\t\t\t3. Update details of  Employee\n \t\t\t\t4. Search employees by name / id / department\n \t\t\t\t5.Search the list of employee for the given department\n \t\t\t\t6.Count of Employee Department Wise\n ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\tPlease enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                int id ;
                string dep;

                switch (choice)
                {
                    case 1:
                       
                        string Employee, role, emailid, mobileno;
                        Console.WriteLine("enter id Employee dep role emailid mobileno");
                        id =Convert.ToInt32(Console.ReadLine()); 
                        Employee = Console.ReadLine();
                        dep = Console.ReadLine();
                        role = Console.ReadLine();
                        emailid = Console.ReadLine();
                        mobileno = Console.ReadLine();

                        Class1.add(id,Employee, dep, role, emailid, mobileno);
                        
                        break;


                    case 2:
                        Console.WriteLine("Enter Employee Id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Class1.delete(id);
                        break;


                    case 3:
                        id = Convert.ToInt32(Console.ReadLine());
                        Class1.update(id);
                       
                        break;


                    case 4:
                        id = Convert.ToInt32(Console.ReadLine());
                        Class1.search();
                        break;


                    case 5:
                        Console.WriteLine("Enter Department");
                        dep = Console.ReadLine();
                        Class1.list(dep);
                        break;

                    case 6:
                        Class1.CountByDepartment();
                        break;

                    default:
                        Console.WriteLine("Please Enter valid Choice ");

                        break;

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
