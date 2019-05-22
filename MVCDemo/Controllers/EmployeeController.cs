using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            List<Employee> list1 = new List<Employee>();
            //string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection("server=localhost; database=employee; uid=root; pwd=");
            string query = "select * from employee";
            MySqlCommand comm = new MySqlCommand(query);
            comm.Connection = mysql;
            mysql.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                list1.Add(new Employee
                {
                    Name = dr["Name"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    City = dr["City"].ToString(),
                });
            }
            mysql.Close();
        
            return View(list1);
        }
    }
}