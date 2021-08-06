using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatKat_Coffee.DataObject;

namespace KatKat_Coffee.DataAccess
{
    class DataAccessLayer
    {
        SqlConnection con;
        String conStr;
        public DataAccessLayer()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = projectDirectory + @"\Database\new_database.mdf";
            con = new SqlConnection();
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @";Integrated Security=True";
        }
        public List<Item> getAllItems()
        {
            List<Item> result = new List<Item>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from items";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Item(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["category"].ToString(), Int64.Parse(reader["price"].ToString())));
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<Item> getAllItemsFromCategory(String category)
        {
            List<Item> result = new List<Item>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from items  where category='" + category + "'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Item(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["category"].ToString(), Int64.Parse(reader["price"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<Item> searchItemFromCategory(String category, String name)
        {
            List<Item> result = new List<Item>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from items where category='" + category + "' and name like '" + name + "%'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Item(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["category"].ToString(), Int64.Parse(reader["price"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<Pet> getAllPets()
        {
            List<Pet> result = new List<Pet>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from pets";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Pet(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["color"].ToString(), 
                            reader["species"].ToString(), reader["gender"].ToString(), reader["owner"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<User> getAllUserInfor()
        {
            List<User> result = new List<User>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from account";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new User(int.Parse(reader["Id"].ToString()), reader["username"].ToString(), reader["password"].ToString(),
                            reader["name"].ToString(), reader["gender"].ToString(), int.Parse(reader["age"].ToString()), reader["role"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<Bill> getAllBill()
        {
            {
                List<Bill> result = new List<Bill>();
                SqlDataReader reader = null;
                try
                {
                    con.ConnectionString = conStr;
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandText = "select * from bill";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Bill(int.Parse(reader["Id"].ToString()), Int64.Parse(reader["price"].ToString()), reader["time"].ToString()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                    con.Dispose();
                }
                return result;
            }
        }

        public bool addItem(Item it)
        {
            bool success = false;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                Console.WriteLine("Current category: " + it.category);
                command.CommandText = "insert into items(name, category, price) values('" + it.name + "','" + it.category + "'," + it.price + ")";
                
                int ret = command.ExecuteNonQuery();
                if (ret == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return success;
        }

        public bool addPet(Pet it)
        {
            bool success = false;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "insert into pets(name, color, species, gender, owner) values (@name, @color, @species, @gender, @owner)";
                command.Parameters.AddWithValue("@name", it.name);
                command.Parameters.AddWithValue("@color", it.color);
                command.Parameters.AddWithValue("@species", it.species);
                command.Parameters.AddWithValue("@gender", it.gender);
                command.Parameters.AddWithValue("@owner", it.owner);
                int ret = command.ExecuteNonQuery();
                if (ret == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return success;
        }

        public bool addMember(User it)
        {
            bool success = false;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = @"insert into account(username, password, name, gender, age, role) values (@username, @password, @name, @gender, @age, @role)";
                command.Parameters.AddWithValue("@username", it.username);
                command.Parameters.AddWithValue("@password", it.password);
                command.Parameters.AddWithValue("@name", it.name);
                command.Parameters.AddWithValue("@gender", it.gender);
                command.Parameters.AddWithValue("@age", it.age);
                command.Parameters.AddWithValue("@role", it.role);
                Console.WriteLine(command.CommandText);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return success;
        }

        public bool addBill(Bill it)
        {
            bool success = false;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                Console.WriteLine("Current price: " + it.price);
                command.CommandText = "insert into bill(price, time) values(" + it.price + ",'" + it.time + "')";
                int ret = command.ExecuteNonQuery();
                if (ret == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return success;
        }

        public List<Item> searchItems (String searchStr)
        {
            List<Item> result = new List<Item>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from items where name like '" + searchStr + "%'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Item(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["category"].ToString(), Int64.Parse(reader["price"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public List<Pet> searchPets(String searchStr)
        {
            List<Pet> result = new List<Pet>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from pets where name like '" + searchStr + "%'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Pet(int.Parse(reader["Id"].ToString()), reader["name"].ToString(), reader["color"].ToString(),
                            reader["species"].ToString(), reader["gender"].ToString(), reader["owner"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }

        public void updateItem(Item it)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "update items set name='" + it.name + "', category='" 
                    + it.category + "', price=" + it.price.ToString() + "where Id=" + it.Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                con.Dispose();
            }
        }

        public void updatePet(Pet it)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "update pets set name='" + it.name + "', color='"
                    + it.color + "', species='" + it.species + "', gender='" + it.gender +"', owner='"
                    + it.owner + "' where Id=" + it.Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        public void updateUser(User it)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "update account set username ='" + it.username + "', password='"
                    + it.password + "', name='" + it.name + "', gender='" + it.gender + "', age='"
                    + it.age + "',  role ='" + it.role + "' where Id=" + it.Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        public void deleteItem(int Id)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from items where Id=" + Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                con.Dispose();
            }
        }

        public void deleteUser(int Id)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from account where Id=" + Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        public void deleteBill(int Id)
        {
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from bill where Id=" + Id;
                command.Connection = con;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        public long getAmount()
        {
            long amount;
            con.ConnectionString = conStr;
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select SUM(price) as amount from bill";
            command.Connection = con;
            amount = (long)command.ExecuteScalar();
            con.Close();

            return amount;
        }
    }
    
}
