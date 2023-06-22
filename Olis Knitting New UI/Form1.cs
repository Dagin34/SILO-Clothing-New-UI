using Olis_Knitting_New_UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olis_Knitting_New_UI
{
    public partial class Form1 : Form
    {
        //.. Initializing of Global Variables
        bool isMaximized = false;

        //.. Manipulating UI Elements
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            //dragControl.TargetControl = userControl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeButton.Checked = true;
            HomeButton.PerformClick();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Silver;
            EmployeeButton.ForeColor = Color.Gray;
            CustomerButton.ForeColor = Color.Gray;
            ItemButton.ForeColor = Color.Gray;
            OrderButton.ForeColor = Color.Gray;
            SettingButton.ForeColor = Color.Gray;
            HomePage homePage = new HomePage();
            addUserControl(homePage);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Gray;
            EmployeeButton.ForeColor = Color.Silver;
            CustomerButton.ForeColor = Color.Gray;
            ItemButton.ForeColor = Color.Gray;
            OrderButton.ForeColor = Color.Gray;
            SettingButton.ForeColor = Color.Gray;
            EmployeePage employeePage = new EmployeePage();
            addUserControl(employeePage);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Gray;
            EmployeeButton.ForeColor = Color.Gray;
            CustomerButton.ForeColor = Color.Silver;
            ItemButton.ForeColor = Color.Gray;
            OrderButton.ForeColor = Color.Gray;
            SettingButton.ForeColor = Color.Gray;
            CustomerPage customerPage = new CustomerPage(); 
            addUserControl(customerPage);
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Gray;
            EmployeeButton.ForeColor = Color.Gray;
            CustomerButton.ForeColor = Color.Gray;
            ItemButton.ForeColor = Color.Silver;
            OrderButton.ForeColor = Color.Gray;
            SettingButton.ForeColor = Color.Gray;
            ItemPage itemPage = new ItemPage();
            addUserControl(itemPage);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Gray;
            EmployeeButton.ForeColor = Color.Gray;
            CustomerButton.ForeColor = Color.Gray;
            ItemButton.ForeColor = Color.Gray;
            OrderButton.ForeColor = Color.Silver;
            SettingButton.ForeColor = Color.Gray;
            OrderPage orderPage = new OrderPage();
            addUserControl(orderPage);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.Gray;
            EmployeeButton.ForeColor = Color.Gray;
            CustomerButton.ForeColor = Color.Gray;
            ItemButton.ForeColor = Color.Gray;
            OrderButton.ForeColor = Color.Gray;
            SettingButton.ForeColor = Color.Silver;
            SettingsPage settingsPage = new SettingsPage();
            addUserControl(settingsPage);
        }

    }
}
