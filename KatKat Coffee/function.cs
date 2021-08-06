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
            string path = projectDirectory + @"\Database\new_database.mdf";
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
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch(Exception e)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
            //cmd.Connection = con;
            //cmd.CommandText = query;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            //da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}
