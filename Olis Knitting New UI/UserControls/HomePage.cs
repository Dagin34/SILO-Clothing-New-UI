using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olis_Knitting_New_UI.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.orderId.Text))
            {
                this.orderId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Order ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.orderId.BorderColor = Color.FromArgb(17, 23, 26);
                this.orderId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.employeeId.Text))
            {
                this.employeeId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Employee ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.employeeId.BorderColor = Color.FromArgb(17, 23, 26);
                this.employeeId.Focus();
                return;
            }

            int orderId = int.Parse(this.orderId.Text);
            int employeeId = int.Parse(this.employeeId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.insertCommission(employeeId, orderId);
            UpdateTable();
            Clear();
            CommissionId.Focus();
        }

        private void UpdateTable()
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.GetAllCommissions().Tables["All"];
            dgv.Columns["Commission ID"].Width = 150;
            dgv.Columns["Order ID"].Width = 100;
            dgv.Columns["Order"].Width = 250;
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CommissionId.Text))
            {
                CommissionId.BorderColor = Color.Red;
                MessageBox.Show("Please Select Order First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommissionId.BorderColor = Color.FromArgb(17, 23, 26);
                CommissionId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.orderId.Text))
            {
                this.orderId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Order ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.orderId.BorderColor = Color.FromArgb(17, 23, 26);
                this.orderId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.employeeId.Text))
            {
                this.employeeId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Employee ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.employeeId.BorderColor = Color.FromArgb(17, 23, 26);
                this.employeeId.Focus();
                return;
            }

            int comId = int.Parse(CommissionId.Text);
            int orderId = int.Parse(this.orderId.Text);
            int employeeId = int.Parse(this.employeeId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.updateCommission(comId, employeeId, orderId);
            UpdateTable();
            Clear();
            CommissionId.Focus();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CommissionId.Text))
            {
                CommissionId.BorderColor = Color.Red;
                MessageBox.Show("Please Select Order First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommissionId.BorderColor = Color.FromArgb(17, 23, 26);
                CommissionId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.orderId.Text))
            {
                this.orderId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Order ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.orderId.BorderColor = Color.FromArgb(17, 23, 26);
                this.orderId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.employeeId.Text))
            {
                this.employeeId.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Employee ID First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.employeeId.BorderColor = Color.FromArgb(17, 23, 26);
                this.employeeId.Focus();
                return;
            }

            int comId = int.Parse(CommissionId.Text);
            int orderId = int.Parse(this.orderId.Text);
            int employeeId = int.Parse(this.employeeId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.deleteCommission(comId, employeeId, orderId);
            UpdateTable();
            Clear();
            this.orderId.Focus();
        }

        private void Clear()
        {
            CommissionId.Clear();
            orderId.Clear();
            employeeId.Clear();
            CommissionId.Focus();
            UpdateTable();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            TableUpdater.Start();
            UpdateTable();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void Commission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '+'))
            {
                e.Handled = true;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CommissionId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                orderId.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeId.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
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
                string orderName = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchCommission(0, orderName).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 1)
            {
                string employeeName = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchCommission(1, employeeName).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 2)
            {
                string customerName = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchCommission(2, customerName).Tables["All"];
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


        //..
        //..Global variables for passing values

        bool choiceForOrder = false;



        //..



        private void chooseEmployee_Click(object sender, EventArgs e)
        {
            popupPanel.Location = new Point(3, 72);
            dgvLabel.Text = "Choose the Employee you want to assign.";
            ThirdLayer tl = new ThirdLayer();
            dgv2.DataSource = tl.GetAllEmployees().Tables["All"];
            choiceForOrder = false;
        }

        private void chooseOrder_Click(object sender, EventArgs e)
        {
            popupPanel.Location = new Point(3, 72);
            dgvLabel.Text = "Choose the Order you want to assign an Employee to.";
            ThirdLayer tl = new ThirdLayer();
            dgv2.DataSource = tl.GetAllOrders().Tables["All"];
            choiceForOrder = true;
        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            popupPanel.Location = new Point(3, 1590);
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choiceForOrder)
            {
                orderId.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
                returnBack.PerformClick();
            }
            else
            {
                employeeId.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
                returnBack.PerformClick();
            }
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
