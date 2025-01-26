using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Olis_Knitting_New_UI.UserControls
{
    public partial class OrderPage : UserControl
    {
        public OrderPage()
        {
            InitializeComponent();
        }


        //..

        bool customerChoice = true;

        //..


        private void OrderPage_Load(object sender, EventArgs e)
        {
            TableUpdater.Start();
            UpdateTable();

            Clear();
        }

        public void UpdateTable()
        {
            ThirdLayer tl = new ThirdLayer();

            if (customerChoice)
            {
                dgvCustomers.DataSource = tl.GetAllCustomers().Tables["All"];
            }
            else
            {
                dgvCustomers.DataSource = tl.GetAllItems().Tables["All"];
            }
            dgv.DataSource = tl.GetAllOrders().Tables["All"];

            int type;
            int prog;
            string stat;

            if (statusChecker.SelectedIndex == 0)
            {
                stat = "All";
            }
            else if (statusChecker.SelectedIndex == 1)
            {
                stat = "Pending";
            }
            else if (statusChecker.SelectedIndex == 2)
            {
                stat = "Finished";
            }
            else if (statusChecker.SelectedIndex == 3)
            {
                stat = "Delivered";
            }
            else
            {
                stat = "All";
            }

            if (progressChecker.SelectedIndex == 0)
            {
                prog = 1;
            }
            else if (progressChecker.SelectedIndex == 1)
            {
                prog = 0;
            }
            else if (progressChecker.SelectedIndex == 2)
            {
                prog = 25;
            }
            else if (progressChecker.SelectedIndex == 3)
            {
                prog = 50;
            }
            else if (progressChecker.SelectedIndex == 4)
            {
                prog = 75;
            }
            else if (progressChecker.SelectedIndex == 5)
            {
                prog = 100;
            }
            else
            {
                prog = 1;
            }


            //.. Algorithm for filtering
            if (stat == "All" && prog == 1)
            {
                dgv.DataSource = tl.GetAllOrders().Tables["All"];
            }
            else if (stat == "All" && prog != 1)
            {
                dgv.DataSource = tl.GetFilteredOrders(2, stat, prog).Tables["All"];
            }
            else if (stat != "All" && prog == 1)
            {
                dgv.DataSource = tl.GetFilteredOrders(1, stat, prog).Tables["All"];
            }
            else if (stat != "All" && prog != 1)
            {
                dgv.DataSource = tl.GetFilteredOrders(0, stat, prog).Tables["All"];
            }

        }

        private void TableUpdater_Tick(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void progressChecker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBy.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing Selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Insert a valid value before searching", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (SearchBy.SelectedIndex == 0)
            {
                string value = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchOrder(true, value).Tables["All"];
                dgvCustomers.DataSource = tl.SearchCust(true, value).Tables["All"];
            }
            if (SearchBy.SelectedIndex == 1)
            {
                string value = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchOrder(false, value).Tables["All"];
                dgvCustomers.DataSource = tl.SearchItem(0, value).Tables["All"];
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                SearchButton.PerformClick();
                txtSearch.Focus();
            }
            else
            {
                UpdateTable();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TableUpdater.Stop();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            TableUpdater.Start();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void Numbers_Only_Key_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            //try
            //{
            //    txtItemId.Text = dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            //}
            //catch (System.ArgumentOutOfRangeException)
            //{
            //    return;
            //}
//}

private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerChoice)
            {
                try
                {
                    txtCustId.Text = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return;
                }
            }
            else
            {
                try
                {
                    txtItemId.Text = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOrderId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();


                // Check to bring customer id
                ThirdLayer tl = new ThirdLayer();
                int CustomersId = tl.getCustomerId(dgv.Rows[e.RowIndex].Cells[1].Value.ToString(), dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtCustId.Text = CustomersId.ToString();

                int ItemsId = tl.getItemId(dgv.Rows[e.RowIndex].Cells[3].Value.ToString(),
                                            dgv.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                            dgv.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtItemId.Text = ItemsId.ToString();

                txtLocation.Text = dgv.Rows[e.RowIndex].Cells[9].Value.ToString();
                statusCombo.Text = dgv.Rows[e.RowIndex].Cells[10].Value.ToString();
                //progressCombo.Text = dgvOrders.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtQuantity.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();


                orderDate.Value = tl.getOrderDate(int.Parse(txtOrderId.Text));
                deliveryDate.Value = tl.getDeliveryDate(int.Parse(txtOrderId.Text));


                string value = dgv.Rows[e.RowIndex].Cells[11].Value.ToString();
                int selectedIndex = -1;
                switch (value)
                {
                    case "0":
                        selectedIndex = 0;
                        break;
                    case "25":
                        selectedIndex = 1;
                        break;
                    case "50":
                        selectedIndex = 2;
                        break;
                    case "75":
                        selectedIndex = 3;
                        break;
                    case "100":
                        selectedIndex = 4;
                        break;
                }
                if (selectedIndex >= 0 && selectedIndex < progressCombo.Items.Count)
                {
                    progressCombo.SelectedIndex = selectedIndex;
                }

                string paidOrNot = dgv.Rows[e.RowIndex].Cells[12].Value.ToString();
                bool isPaid = false;
                switch (paidOrNot)
                {
                    case "Paid":
                        isPaid = true;
                        break;
                    case "Not Paid":
                        isPaid = false;
                        break;
                }

                if (isPaid)
                {
                    paid.Checked = true;
                    notPaid.Checked = false;
                }
                else
                {
                    notPaid.Checked = true;
                    paid.Checked = false;
                }

            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void Clear()
        {
            txtOrderId.Clear();
            txtCustId.Clear();
            txtItemId.Clear();
            orderDate.Value = DateTime.Now;
            deliveryDate.Value = DateTime.Now;
            txtLocation.Clear();
            statusCombo.SelectedIndex = 0;
            progressCombo.SelectedIndex = 0;
            progressChecker.SelectedIndex = 0;
            paid.Checked = false;
            notPaid.Checked = false;
            txtQuantity.Clear();


            //txtCustId.Focus();
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCustId.Text))
            {
                txtCustId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert CustomerId First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustId.BorderColor = Color.FromArgb(17, 23, 26);
                txtCustId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtItemId.Text))
            {
                txtItemId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert ItemId First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemId.BorderColor = Color.FromArgb(17, 23, 26);
                txtItemId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.BorderColor = Color.Red;
                MessageBox.Show("Please Insert The location you are ordering to", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.BorderColor = Color.FromArgb(17, 23, 26);
                txtLocation.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Quantity of the Order First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.BorderColor = Color.FromArgb(17, 23, 26);
                txtQuantity.Focus();
                return;
            }

            int custid = int.Parse(txtCustId.Text);
            int itemid = int.Parse(txtItemId.Text);
            DateTime ordered = orderDate.Value.Date;
            DateTime delivery = deliveryDate.Value.Date;
            string loc = txtLocation.Text;
            int quan = int.Parse(txtQuantity.Text);
            string status = "Pending";
            int progress = 0;
            string paidOrNaw = "Paid";

            //.. Checking the Status
            if (statusCombo.SelectedIndex == 1)
                status = "Finished";
            else if (statusCombo.SelectedIndex == 2)
                status = "Delivered";

            //.. Checking the Progress
            if (progressCombo.SelectedIndex == 1)
                progress = 25;
            else if (progressCombo.SelectedIndex == 2)
                progress = 50;
            else if (progressCombo.SelectedIndex == 3)
                progress = 75;
            else if (progressCombo.SelectedIndex == 4)
                progress = 100;

            //.. Checking the Paid or Not Status
            if (notPaid.Checked)
                paidOrNaw = "Not Paid";

            ThirdLayer tl = new ThirdLayer();
            tl.insertOrder(custid, itemid, ordered, delivery, loc, status, progress, paidOrNaw, quan);
            UpdateTable();
            Clear();
        }

        private void updateOrder_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOrderId.Text))
            {
                txtOrderId.BorderColor = Color.Red;
                MessageBox.Show("Please Choose the Order you want to edit.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.BorderColor = Color.FromArgb(17, 23, 26);
                txtOrderId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustId.Text))
            {
                txtCustId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert CustomerId First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustId.BorderColor = Color.FromArgb(17, 23, 26);
                txtCustId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtItemId.Text))
            {
                txtItemId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert ItemId First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemId.BorderColor = Color.FromArgb(17, 23, 26);
                txtItemId.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.BorderColor = Color.Red;
                MessageBox.Show("Please Insert The location you are ordering to", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.BorderColor = Color.FromArgb(17, 23, 26);
                txtLocation.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Quantity of the Order First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.BorderColor = Color.FromArgb(17, 23, 26);
                txtQuantity.Focus();
                return;
            }


            int orderid = int.Parse(txtOrderId.Text);
            int custid = int.Parse(txtCustId.Text);
            int itemid = int.Parse(txtItemId.Text);
            DateTime ordered = orderDate.Value.Date;
            DateTime delivery = deliveryDate.Value.Date;
            string loc = txtLocation.Text;
            int quan = int.Parse(txtQuantity.Text);
            string status = "Pending";
            int progress = 0;
            string paidOrNaw = "Paid";

            //.. Checking the Status
            if (statusCombo.SelectedIndex == 1)
                status = "Finished";
            else if (statusCombo.SelectedIndex == 2)
                status = "Delivered";

            //.. Checking the Progress
            if (progressCombo.SelectedIndex == 1)
                progress = 25;
            else if (progressCombo.SelectedIndex == 2)
                progress = 50;
            else if (progressCombo.SelectedIndex == 3)
                progress = 75;
            else if (progressCombo.SelectedIndex == 4)
                progress = 100;

            //.. Checking the Paid or Not Status
            if (notPaid.Checked)
                paidOrNaw = "Not Paid";

            ThirdLayer tl = new ThirdLayer();
            tl.updateOrder(orderid, custid, itemid, ordered, delivery, loc, status, progress, paidOrNaw, quan);
            UpdateTable();
            Clear();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOrderId.Text))
            {
                txtOrderId.BorderColor = Color.Red;
                MessageBox.Show("Please Choose the Order you want to delete.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.BorderColor = Color.FromArgb(17, 23, 26);
                txtOrderId.Focus();
                return;
            }

            int orderid = int.Parse(txtOrderId.Text);
            ThirdLayer tl = new ThirdLayer();
            tl.deleteOrder(orderid);
            UpdateTable();
            Clear();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            int idToSend = int.Parse(txtOrderId.Text);
            string fullName = tl.getCustName(idToSend);
            string ordered = orderDate.Value.ToString("dddd, MMMM d, yyyy");
            string delivered = deliveryDate.Value.ToString("dddd, MMMM d, yyyy");
            string loca = txtLocation.Text;
            string quan = txtQuantity.Text;
            string itemName = tl.getItemName(idToSend);
            string itemSize = tl.getItemSize(idToSend);

            string message =
                "Dear " + fullName + ",\r\n\r\n" +
                "" +
                "We would like to remind you of the details of the order put down on '" + ordered + "', which is " +
                "" + quan + " Items with the name: " + itemName + " and size " + itemSize + ". Please note that the Delivery Date " +
                "was set to '" + delivered + "' and the location as " + loca + ".\r\n\r\n" +
                "" +
                "We kindly request that you settle the payment before the delivery date to avoid any delays " +
                "or complications.\r\n\r\n" +
                "" +
                "We hope that you are looking forward to receiving your order, and we assure you that we are " +
                "doing our best to ensure that it will be delivered to you on time and in good condition.\r\n\r\n" +
                "" +
                "If you have any questions or concerns regarding your order, please do not hesitate to contact us." +
                " We would be more than happy to assist you.\r\n\r\n" +
                "" +
                "Thank you for choosing us as your supplier.";

            //.. Copy to clipboard
            Clipboard.SetText(message);
            MessageBox.Show("Copied to ClipBoard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_MouseEnter(object sender, EventArgs e)
        {
            TableUpdater.Stop();
        }

        private void dgv_MouseLeave(object sender, EventArgs e)
        {
            TableUpdater.Start();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void progressChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void chooseItem_Click(object sender, EventArgs e)
        {
            customerChoice = false;
            UpdateTable();
            choiceLabel.Text = "Items Table";
        }

        private void chooseCustomer_Click(object sender, EventArgs e)
        {
            customerChoice = true;
            UpdateTable();
            choiceLabel.Text = "Customers Table";
        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {
            string contactInformation = "Name: Dagmawi Napoleon\nEmail: dagmawinapoleon02@gmail.com\nTelegram: @dagi_n34";
            Clipboard.SetText(contactInformation);
            MessageBox.Show("Contact Information Copied to Clipboard", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ContactLabel_MouseEnter(object sender, EventArgs e)
        {
            contactLabel.ForeColor = Color.FromArgb(175, 228, 255);
        }

        private void contactLabel_MouseLeave(object sender, EventArgs e)
        {
            contactLabel.ForeColor = Color.FromArgb(132, 172, 192);
        }
    }
}
