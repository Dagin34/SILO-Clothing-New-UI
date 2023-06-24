using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Olis_Knitting_New_UI.UserControls
{
    public partial class CustomerPage : UserControl
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            CustomerCount.Start();
            TableUpdater.Start();
            UpdateTable();
        }

        private void UpdateTable()
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.GetAllCustomers().Tables["All"];
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //.. Search Function
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
                string type = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchCust(true, type).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 1)
            {
                string color = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchCust(false, color).Tables["All"];
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNumber.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '+'))
            {
                e.Handled = true;
            }
        }

        private void TableUpdater_Tick(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void CustomerCount_Tick(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            CustCount.Text = tl.CustomerCount().ToString();
        }

        private void Clear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNumber.Clear();
            txtFirstName.Focus();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert First Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.BorderColor = Color.FromArgb(43, 43, 43);
                txtFirstName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Last Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.BorderColor = Color.FromArgb(43, 43, 43);
                txtLastName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                txtNumber.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Phone Number First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.BorderColor = Color.FromArgb(43, 43, 43);
                txtNumber.Focus();
                return;
            }

            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phoneNumber = txtNumber.Text;

            ThirdLayer tl = new ThirdLayer();
            tl.insertCustomer(firstname, lastname, phoneNumber);
            UpdateTable();
            Clear();
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the Customer you want to update from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert First Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.BorderColor = Color.FromArgb(43, 43, 43);
                txtFirstName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Last Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.BorderColor = Color.FromArgb(43, 43, 43);
                txtLastName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                txtNumber.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Phone Number First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.BorderColor = Color.FromArgb(43, 43, 43);
                txtNumber.Focus();
                return;
            }

            int id = int.Parse(txtId.Text);
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phoneNumber = txtNumber.Text;

            ThirdLayer tl = new ThirdLayer();
            tl.updateCustomer(id, firstname, lastname, phoneNumber);
            UpdateTable();
            Clear();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the Customer you want to update from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }

            int id = int.Parse(txtId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.deleteCustomer(id);
            UpdateTable();
            Clear();
        }
    }
}
