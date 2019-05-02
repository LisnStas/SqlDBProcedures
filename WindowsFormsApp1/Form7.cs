using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // showAllPresidents button event handler      
        private void showAllPresidents_Click(object sender, EventArgs e)
        {
            // read from config file db connection string
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;

            // connect to data base
            using (var conn = new SqlConnection(connection))

            // create command for a procedure SelectPresYears execution 
            using (var command = new SqlCommand("SelectPresYears", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();

                // add parameters to command, which will be passed to the stored procedure
                command.Parameters.Add(new SqlParameter("@pres_from", "1896-01-01"));
                command.Parameters.Add(new SqlParameter("@pres_to", "2022-01-01"));
                
                // execute the command
                SqlDataReader reader = command.ExecuteReader();
                
                // iterate through results
                while (reader.Read())
                {
                    // Format results into string
                    string str = string.Format("{0,-15} {1,-10} {2,10} - {3,10}",reader["pres_fname"], reader["pres_lname"], reader["pres_from"], reader["pres_to"]);

                    // insert string in the listBoxDisplay 
                    listBoxDisplay.Items.Add(str);
                }
            }

        }
    }
}
