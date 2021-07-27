using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace KatKat_Coffee
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            // Console.WriteLine(projectDirectory);
            string path = projectDirectory + @"\Database\katkat.mdf";
            // C:\Users\TVThanh\Downloads\Compressed\KatKat Coffee\KatKat Coffee
            // C:\Users\TVThanh\Downloads\Compressed\KatKat Coffee\KatKat Coffee\KatKat Coffee

            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            string PathY = "C:\\Users\\Yuuto\\source\\repos\\KatKat-Coffee\\KatKat Coffee\\Database\\katkat.mdf";
            string YuutoConString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = "+PathY+"; Integrated Security = True; Connect Timeout = 30";
            con.ConnectionString = YuutoConString;
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
