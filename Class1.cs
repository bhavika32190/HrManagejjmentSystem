using System;
using System.Data.SqlClient;
namespace HRM
{
    public class Class1
    {
        static SqlDataReader dr;
        static SqlConnection con;
        static SqlCommand cmd;
        static int id;
        public static void ADD(int id,string Employee,string dep, string role,string emailid,string mobileno)
        {

            string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            string query = "insert into Empdetails values(" + id + ",'"  + Employee + "','" + dep + "','" + role + "','" + emailid + "','" + mobileno +"')";
            cmd = new SqlCommand(query, con);
         
            try
            {
               // con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(System.Data.SqlClient.SqlException ex)

            {
                string msg = "insert Error";
                msg += ex.Message;

            }
            Console.WriteLine("Record inserted");
            Console.ReadKey();

            con.Close();
           
        }


        public static void DELETE(int id)
        {

            string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            string query = "delete Empdetails where id=" + id;
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record Deleted");
            Console.Read();
            con.Close();
        }


        

        public static void UPDATE(int id)
        {
            Console.WriteLine("1.Update Name\n 2.Update Department\n 3.Update Role\n 4.Update EmailId\n 5.Update Mobileno.");
            int up =Convert.ToInt32(Console.ReadLine());
            switch (up)
            {
                case 1:
                Console.WriteLine("Enter Your New Name");
                    String Name = Console.ReadLine();
                    string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr;

                    con.Open();
                    

                    cmd = new SqlCommand("UPDATE Empdetails set Employee='" + Name + "'" + "where id=" + id, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");
                    Console.Read();
                    con.Close();
                    break;

                case 2:
                    Console.WriteLine("Enter Your Department");
                    String Department = Console.ReadLine();
                    string constr1 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr1;

                    con.Open();
          

                    cmd = new SqlCommand("UPDATE Empdetails set department='" + Department + "'" + "where id=" + id, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");
                    Console.Read();
                    con.Close();
                    break;

                case 3:
                    Console.WriteLine("Enter Your New Role");
                    String Role = Console.ReadLine();
                    string constr2 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr2;

                    con.Open();
                    

                    cmd = new SqlCommand("UPDATE Empdetails set role='" + Role + "'" + "where id=" + id, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");
                    Console.Read();
                    con.Close();
                    break;

                case 4:
                    Console.WriteLine("Enter Your New EmailID");
                    String EmailId = Console.ReadLine();
                    string constr3 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr3;

                    con.Open();
                   

                    cmd = new SqlCommand("UPDATE Empdetails set EmailID='" + EmailId + "'" + "where id=" + id, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");
                    Console.Read();
                    con.Close();
                    break;

                case 5:
                    Console.WriteLine("Enter Your New Mobileno");
                    String Mobileno = Console.ReadLine();
                    string constr4 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr4;

                    con.Open();
                   

                    cmd = new SqlCommand("UPDATE Empdetails set Mobileno='" + Mobileno + "'" + "where id=" + id, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");
                    Console.Read();
                    con.Close();
                    break;
                default:
                    break;
            }
            }

        public static void SEARCH()
        {
            Console.WriteLine(" 1.Search by id\n 2.Search by name\n 3.Search by department");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("enter id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr;

                    con.Open();


                    string query = "Select * from Empdetails where id=" + id;

                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();
                    Console.WriteLine("id\t Employee\t Department\t\t Role\t\t EmailID\t\t\t Mobileno.\n ");
                    while (dr.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\n", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

                    }
                    con.Close();
                    break;


                case 2:
                    Console.WriteLine("Enter Name");
                    string Name = Console.ReadLine();
                    string constr1 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr1;

                    con.Open();


                    

                    cmd = new SqlCommand("Select * from Empdetails where Employee =" + "'" + Name + "'", con);
                    dr = cmd.ExecuteReader();
                    Console.WriteLine("id\t Employee\t Department\t\t Role\t\t EmailID\t\t\t Mobileno.\n ");
                    while (dr.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\n", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

                    }
                    con.Close();
                    break;

                case 3:
                    Console.WriteLine("Enter Department");
                    string Dep = Console.ReadLine();
                    string constr2 = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
                    con = new SqlConnection();
                    con.ConnectionString = constr2;

                    con.Open();


                   

                    cmd = new SqlCommand("Select * from Empdetails where department =" + "'" + Dep + "'", con);
                    dr = cmd.ExecuteReader();
                    Console.WriteLine("id\t Employee\t Department\t\t Role\t\t EmailID\t\t\t Mobileno.\n ");
                    while (dr.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\n", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

                    }
                    con.Close();
                    break;

                default:
                    Console.WriteLine("wrong Choice");
                    break;

            }
        }



        public static void LIST(String Dep)
        {
            string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
            con = new SqlConnection();
            con.ConnectionString = constr;

            con.Open();
               string query = "select Employee from Empdetails where department=" + "'" + Dep + "'";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("List of employee for the given department");
            while (dr.Read())
            {
                Console.WriteLine("{0}", dr[0]);

            }
            con.Close();
        }




        public static void CountByDepartment()
        {
            string constr = "Data source=DESKTOP-28G3M0N; initial catalog=HRM;user=sa;password=12345";
            con = new SqlConnection();
            con.ConnectionString = constr;

            con.Open();


            string query = "select  Department, Count(*) from Empdetails group by department order by department desc";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Department\t\tCount of Employee ");
            while (dr.Read())
            {
                Console.WriteLine("{0}\t\t{1}",dr[0],dr[1]);
            
            }
            con.Close();
        }




       

        }
}
