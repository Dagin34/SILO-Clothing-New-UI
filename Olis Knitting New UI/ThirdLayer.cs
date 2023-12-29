using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Olis_Knitting_New_UI
{
    internal class ThirdLayer
    {
        //.. Global Variable Declaration
        SqlConnection con;
        string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\Desktop\\Personal Documents\\Extra Projects\\Olis v2\\Olis Knitting New UI\\Olis Knitting New UI\\OlisDatabase.mdf\";Integrated Security=True";


        //.. Items Manipulation ==================================================================================================================================

        #region Items Manipulation

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

        #endregion

        #region Items GET Function


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

        #endregion




        //.. Customer Manipulation ==================================================================================================================================

        #region Customer Manipulation

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

        #endregion

        #region Customer GET Function

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

        #endregion




        //.. Employee Manipulation ==================================================================================================================================

        #region Employee Manipulation

        public void insertEmployee(string firstname, string lastname, string number, int yarncount)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);
                    cmd.Parameters.AddWithValue("@YarnCount", yarncount);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Emplyee Saved Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error saving Employee!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting: Exception");
            }
        }

        public void updateEmployee(int id, string firstname, string lastname, string number, int yarncount)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("updateEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", id);
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);
                    cmd.Parameters.AddWithValue("@YarnCount", yarncount);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Emplyee Updated Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error updating Employee!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error updating: Exception");
            }
        }

        public void deleteEmployee(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select FirstName from Employees where EmployeeId = " + id, con);
                    string firstname = (string)cmd1.ExecuteScalar();

                    cmd1 = new SqlCommand("select LastName from Employees where EmployeeId = " + id, con);
                    string lastname = (string)cmd1.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("deleteEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    DialogResult dg = MessageBox.Show("Are you sure you want to PERMANENTLY DELETE Employee " + firstname + " " + lastname + "?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        SqlDataAdapter da = new SqlDataAdapter("EmployeeExists", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@EmpId", id);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Employee is working on an Order so he/she can not be deleted", "Unauthorized Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int changes = cmd.ExecuteNonQuery();
                        if (changes > 0)
                        {
                            MessageBox.Show("Emplyee Deleted Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Error Deleting Employee!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Chosen not to delete!", "Not Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error updating: Exception");
            }
        }

        #endregion

        #region Employee GET Function

        //.. Employee GET Function ====================================

        public DataSet GetAllEmployees()
        {
            using (con = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllEmplopyee", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "All");
                return ds;
            }
        }

        public DataSet SearchEmployee (int byType, int yarn, string value)
        {
            if (byType == 0)    //.. Search Employees by their NAMES
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("EmployeeByName", con);
                    da.SelectCommand.Parameters.AddWithValue("@NameChecker", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else if (byType == 1)       //.. Search Employees by their YARN COUNT
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("EmployeeByYarnCount", con);
                    da.SelectCommand.Parameters.AddWithValue("@YarnCount", yarn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else            //.. Search Employees by their NUMBER
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("EmployeeByNumber", con);
                    da.SelectCommand.Parameters.AddWithValue("@Number", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
        }

        public int EmployeeCount()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "select count(EmployeeId) from Employees";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch (SqlException ex)
            {
                return -1;
            }
        }

        #endregion




        //.. Order Manipulation ==================================================================================================================================

        #region Order Manipulation

        public void insertOrder(int CustomerId, int ItemId, DateTime OrderDate, DateTime DeliveryDate, string Location, string Status, int Progress, string Paid, int Quantity)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    cmd.Parameters.AddWithValue("@ItemId", ItemId);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Progress", Progress);
                    cmd.Parameters.AddWithValue("@Paid", Paid);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Order Created Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error Creating Order!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting: Exception");
            }
        }

        public void updateOrder(int orderId, int CustomerId, int ItemId, DateTime OrderDate, DateTime DeliveryDate, string Location, string Status, int Progress, string Paid, int Quantity)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    cmd.Parameters.AddWithValue("@ItemId", ItemId);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                    cmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Progress", Progress);
                    cmd.Parameters.AddWithValue("@Paid", Paid);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Order Updated Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error Updating Order!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating: Exception");
            }
        }

        public void deleteOrder(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("deleteOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderId", id);


                    string itemName = getItemName(id);
                    string name = getCustName(id);



                    string message =
                        "Are you sure you want to delete Item: " + itemName + " ordered by Customer: " +
                        name + "?";

                    DialogResult dg = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        int changes = cmd.ExecuteNonQuery();
                        if (changes > 0)
                        {
                            MessageBox.Show("Order Deleted Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Error Deleting Order!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Chosen not to delete the Order!", "Not Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error updating: Exception");
            }
        }

        #endregion

        #region Order GET Function

        //.. Order GET Function ====================================

        public DataSet GetAllOrders()
        {
            using (con = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter("AllOrders", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "All");
                return ds;
            }
        }

        public DataSet GetFilteredOrders(int type, string stat, int prog)
        {
            if (type == 0)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("AllOrdersByStatusProgress", con);
                    da.SelectCommand.Parameters.AddWithValue("@stat", stat);
                    da.SelectCommand.Parameters.AddWithValue("@prog", prog);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else if (type == 1)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("AllOrdersByStatus", con);
                    da.SelectCommand.Parameters.AddWithValue("@stat", stat);
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
                    SqlDataAdapter da = new SqlDataAdapter("AllOrdersByProgress", con);
                    da.SelectCommand.Parameters.AddWithValue("@prog", prog);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
        }

        public DataSet SearchOrder(bool isByName, string value)
        {
            if (isByName)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchOrderByCustomerName", con);
                    da.SelectCommand.Parameters.AddWithValue("@NameChecker", value);
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
                    SqlDataAdapter da = new SqlDataAdapter("SearchOrdersByItemType", con);
                    da.SelectCommand.Parameters.AddWithValue("@Type", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
        }

        public int getCustomerId(string firstname, string lastname)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SendBackCustomerId", con);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = (int)cmd.ExecuteScalar();
                    return id;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public string getCustName(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    //.. For Convinence 
                    string getCustomerFirstName =
                        "select C.FirstName from Orders as O " +
                        "inner join Customers as C " +
                        "   on O.CustomerId = C.CustomerId " +
                        "where O.OrderId = " + id;

                    string getCustomerLastName =
                        "select C.LastName from Orders as O " +
                        "inner join Customers as C " +
                        "   on O.CustomerId = C.CustomerId " +
                        "where O.OrderId = " + id;

                    SqlCommand cmd1;
                    cmd1 = new SqlCommand(getCustomerFirstName, con); //..Getting Customers FirstName
                    string firstname = (string)cmd1.ExecuteScalar();

                    SqlCommand cmd2;
                    cmd2 = new SqlCommand(getCustomerLastName, con); //..Getting Customers LastName
                    string lastname = (string)cmd2.ExecuteScalar();

                    return firstname + " " + lastname;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int getItemId(string type, string color, string size)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SendBackItemId", con);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@size", size);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = (int)cmd.ExecuteScalar();
                    return id;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public string getItemName(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    string getItemName =
                        "select I.Name from Orders as O " +
                        "inner join Items as I " +
                        "   on O.ItemId = I.ItemId " +
                        "where O.OrderId = " + id;

                    SqlCommand cmd1;
                    cmd1 = new SqlCommand(getItemName, con);         //..Getting the Item Ordered
                    string itemName = (string)cmd1.ExecuteScalar();
                    return itemName;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string getItemSize(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();

                    string getItemName =
                        "select I.Size from Orders as O " +
                        "inner join Items as I " +
                        "   on O.ItemId = I.ItemId " +
                        "where O.OrderId = " + id;

                    SqlCommand cmd1;
                    cmd1 = new SqlCommand(getItemName, con);         //..Getting the Item Ordered
                    string itemSize = (string)cmd1.ExecuteScalar();
                    return itemSize;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DateTime getOrderDate(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select OrderDate from Orders where OrderId = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.CommandType = CommandType.Text;

                    DateTime date = (DateTime)cmd.ExecuteScalar();
                    return date;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return DateTime.Now;
            }
        }

        public DateTime getDeliveryDate(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select DeliveryDate from Orders where OrderId = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.CommandType = CommandType.Text;

                    DateTime date = (DateTime)cmd.ExecuteScalar();
                    return date;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return DateTime.Now;
            }
        }

        #endregion




        //.. Commission Manipulation ==================================================================================================================================

        #region Commission Manipulation

        public void insertCommission(int EmployeeId, int OrderId)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertCommission", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    cmd.Parameters.AddWithValue("@OrderId", OrderId);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Employee Commission Created Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error Creating Commission!", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting: Exception");
            }
        }

        public void updateCommission(int ComId, int EmployeeId, int OrderId)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateCommission", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComId", ComId);
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    cmd.Parameters.AddWithValue("@OrderId", OrderId);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Employee Commission Updated Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Error Updating Commission!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Inserting: Exception");
            }
        }

        public void deleteCommission(int ComId, int EmployeeId, int OrderId)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("deleteCommission", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComId", ComId);

                    SqlCommand cmd1 = new SqlCommand("select FirstName from Employees where EmployeeId = @EmployeeId", con);
                    cmd1.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    string firstname = (string)cmd1.ExecuteScalar();

                    cmd1 = new SqlCommand("select LastName from Employees where EmployeeId = @EmployeeId", con);
                    cmd1.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    string lastname = (string)cmd1.ExecuteScalar();

                    DialogResult dg = MessageBox.Show("" +
                        "Are you sure you want to delete Employee " + firstname + " " + lastname + "'s commisison " +
                        "on the Order: " + OrderId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        int changes = cmd.ExecuteNonQuery();
                        if (changes > 0)
                        {
                            MessageBox.Show("Commission Deleted Succesfully!", "Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        MessageBox.Show("Error Deleting Commission!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Chosen not to delete the Commission!", "Not Affected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting: Exception");
            }
        }

        #endregion

        #region Commission GET Function

        //.. Commission GET Function ====================================


        public DataSet GetAllCommissions()
        {
            using (con = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllCommissions", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "All");
                return ds;
            }
        }

        public DataSet SearchCommission(int isByOrder, string value)
        {
            if (isByOrder == 0)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchCommissionByOrder", con);
                    da.SelectCommand.Parameters.AddWithValue("@ItemName", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else if (isByOrder == 1)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchCommissionByEmployee", con);
                    da.SelectCommand.Parameters.AddWithValue("@EmployeeName", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else if (isByOrder == 2)
            {
                using (con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchCommissionByCustomer", con);
                    da.SelectCommand.Parameters.AddWithValue("@CustomerName", value);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "All");
                    return ds;
                }
            }
            else
            {
                MessageBox.Show("There was a problem choosing the option to search", "Error Choosing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion



    }
}
