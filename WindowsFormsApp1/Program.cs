using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using Survival.Models;

namespace Survival
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /*
            using (GameDbContext context = new GameDbContext())
               {
                   User user = new User();
                   user.Name = "Test1";
                   user.Password = "Test12";
                   user.Score = 7;
                   context.User.Add(user);
                   context.SaveChanges();
               }
            */
             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form5());

           
        }

       
        

    }
}
