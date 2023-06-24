using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olis_Knitting_New_UI
{
    internal class ThirdLayer
    {
        //.. Global Variable Declaration
        SqlConnection con;
        string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\Desktop\\Personal Documents\\Projects\\Olis v2\\Olis Knitting New UI\\Olis Knitting New UI\\OlisDatabase.mdf\";Integrated Security=True";


        //.. Items Manipulation ==================================================================================================================================
        public void insertItems(string name, string type, string color, string size, int quantity, int price)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertItems", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Color", color);
                    cmd.Parameters.AddWithValue("@Size", size);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);


                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Item Added Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error adding Item!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting: Exception");
            }
        }

        public void updateItems(int id, string name, string type, string color, string size, int quantity, int price)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UpdateItems", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemId", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Color", color);
                    cmd.Parameters.AddWithValue("@Size", size);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);


                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Item Updated Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error updating Item!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating: Exception");
            }
        }

        public void deleteItem(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("deleteItems", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemId", id);

                    //.. For Convinence 
                    SqlCommand cmd1 = new SqlCommand("select Type from Items where ItemId = " + id, con);
                    string type = (string)cmd1.ExecuteScalar();

                    cmd1 = new SqlCommand("select Color from Items where ItemId = " + id, con);
                    string color = (string)cmd1.ExecuteScalar();

                    cmd1 = new SqlCommand("select Name from Items where ItemId = " + id, con);
                    string name = (string)cmd1.ExecuteScalar();

                    DialogResult dg = MessageBox.Show("Are you sure you want to PERMANENTLY DELETE Item " + type + " with color " + color + " saved as " + name + "?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        SqlDataAdapter da = new SqlDataAdapter("ItemExists", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@ItemId", id);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This items exists in Orders so can not delete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int changes = cmd.ExecuteNonQuery();
                        if (changes > 0)
                        {
                            MessageBox.Show("Item Deleted Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Error Deleting Item!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Chosen not to delete!", "Not Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting: Exception");
            }
        }


        //.. Items GET Function ====================================

        public DataSet GetAllItems()
        {
            using (con = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllItems", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "All");
                return ds;
            }
        }

        public DataSet SearchItem(int byType, string demo)
        {
            using (con = new SqlConnection(str))
            {
                if (byType == 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchItemByType", con);
                    da.SelectCommand.Parameters.AddWithValue("@Type", demo);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
                else if (byType == 1)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchItemByColor", con);
                    da.SelectCommand.Parameters.AddWithValue("@Color", demo);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchItemByName", con);
                    da.SelectCommand.Parameters.AddWithValue("@Name", demo);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
        }

        public int ItemCount()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "select count(ItemId) from Items";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch(SqlException ex)
            {
                return 0;
            }
        }

        //.. Customer Manipulation ==================================================================================================================================

        public void insertCustomer(string firstname, string lastname, string number)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Customer Saved Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error saving Customer!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    MessageBox.Show("Customer with number " + number + " already exists", "Not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error Inserting: Excpetion " + ex.GetType().Name);
            }
        }

        public void updateCustomer(int id, string firstname, string lastname, string number)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("updateCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", id);
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Customer Updated Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error updating Customer!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    MessageBox.Show("Customer with number " + number + " already exists", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                MessageBox.Show(ex.Message, "Error updating: Exception");
            }
        }

        public void deleteCustomer(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("select FirstName from Customers where CustomerId = @Id ", con);
                    cmd1.Parameters.AddWithValue("@Id", id);
                    string firstname = (string)cmd1.ExecuteScalar();

                    cmd1 = new SqlCommand("select LastName from Customers where CustomerId = @Id ", con);
                    cmd1.Parameters.AddWithValue("@Id", id);
                    string lastname = (string)cmd1.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("deleteCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", id);

                    DialogResult dg = MessageBox.Show("Are you sure you want to PERMANENTLY DELETE Customer " + firstname + " " + lastname + "?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {

                        SqlDataAdapter da = new SqlDataAdapter("CustomerExists", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@CustId", id);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Customer exists in Orders so can not delete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        int changes = cmd.ExecuteNonQuery();
                        if (changes > 0)
                        {

                            MessageBox.Show("Customer Deleted Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Error Deleting Customer!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Chosen not to delete!", "Not Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting: Exception");
            }
        }

        //.. Customer GET Function ====================================

        public DataSet GetAllCustomers()
        {
            using (con = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetCustomers", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "All");
                return ds;
            }
        }

        public DataSet SearchCust(bool byName, string name)
        {
            if (byName)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchCustomersByName", con);
                    da.SelectCommand.Parameters.AddWithValue("@NameChecker", name);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchCustomersByNumber", con);
                    da.SelectCommand.Parameters.AddWithValue("@Number", name);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
        }

        public int CustomerCount()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "select count(CustomerId) from Customers";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch(SqlException ex)
            {
                return -1;
            }
        }

    }
}
