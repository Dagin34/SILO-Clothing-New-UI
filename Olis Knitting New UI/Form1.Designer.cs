namespace Olis_Knitting_New_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OrderButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SettingButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ItemButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CustomerButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EmployeeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.HomeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MinimizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MaximizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FormDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.FormPanel.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.MinimizeButton);
            this.FormPanel.Controls.Add(this.MaximizeButton);
            this.FormPanel.Controls.Add(this.CloseButton);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanel.Location = new System.Drawing.Point(1, 1);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1449, 33);
            this.FormPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Olis Knitting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NavPanel.Controls.Add(this.OrderButton);
            this.NavPanel.Controls.Add(this.SettingButton);
            this.NavPanel.Controls.Add(this.ItemButton);
            this.NavPanel.Controls.Add(this.CustomerButton);
            this.NavPanel.Controls.Add(this.EmployeeButton);
            this.NavPanel.Controls.Add(this.HomeButton);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(1, 34);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(200, 739);
            this.NavPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(201, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1249, 739);
            this.MainPanel.TabIndex = 2;
            // 
            // OrderButton
            // 
            this.OrderButton.AnimationHoverSpeed = 0.07F;
            this.OrderButton.AnimationSpeed = 0.03F;
            this.OrderButton.BackColor = System.Drawing.Color.Transparent;
            this.OrderButton.BaseColor = System.Drawing.Color.Transparent;
            this.OrderButton.BorderColor = System.Drawing.Color.Black;
            this.OrderButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.OrderButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.OrderButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.OrderButton.CheckedForeColor = System.Drawing.Color.White;
            this.OrderButton.CheckedImage = global::Olis_Knitting_New_UI.Properties.Resources.Order;
            this.OrderButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.OrderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderButton.FocusedColor = System.Drawing.Color.Empty;
            this.OrderButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.Silver;
            this.OrderButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Order;
            this.OrderButton.ImageSize = new System.Drawing.Size(23, 23);
            this.OrderButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.OrderButton.Location = new System.Drawing.Point(0, 631);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OrderButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrderButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Order;
            this.OrderButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.OrderButton.OnPressedColor = System.Drawing.Color.Black;
            this.OrderButton.Size = new System.Drawing.Size(200, 54);
            this.OrderButton.TabIndex = 5;
            this.OrderButton.Text = "Orders";
            this.OrderButton.TextOffsetX = 10;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.AnimationHoverSpeed = 0.07F;
            this.SettingButton.AnimationSpeed = 0.03F;
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.BaseColor = System.Drawing.Color.Transparent;
            this.SettingButton.BorderColor = System.Drawing.Color.Black;
            this.SettingButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.SettingButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SettingButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SettingButton.CheckedForeColor = System.Drawing.Color.White;
            this.SettingButton.CheckedImage = global::Olis_Knitting_New_UI.Properties.Resources.Settings;
            this.SettingButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.Silver;
            this.SettingButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Settings;
            this.SettingButton.ImageSize = new System.Drawing.Size(23, 23);
            this.SettingButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SettingButton.Location = new System.Drawing.Point(0, 685);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Settings;
            this.SettingButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SettingButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingButton.Size = new System.Drawing.Size(200, 54);
            this.SettingButton.TabIndex = 4;
            this.SettingButton.Text = "Settings";
            this.SettingButton.TextOffsetX = 10;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.AnimationHoverSpeed = 0.07F;
            this.ItemButton.AnimationSpeed = 0.03F;
            this.ItemButton.BackColor = System.Drawing.Color.Transparent;
            this.ItemButton.BaseColor = System.Drawing.Color.Transparent;
            this.ItemButton.BorderColor = System.Drawing.Color.Black;
            this.ItemButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.ItemButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ItemButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ItemButton.CheckedForeColor = System.Drawing.Color.White;
            this.ItemButton.CheckedImage = global::Olis_Knitting_New_UI.Properties.Resources.Item;
            this.ItemButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.ItemButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemButton.ForeColor = System.Drawing.Color.Silver;
            this.ItemButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Item;
            this.ItemButton.ImageSize = new System.Drawing.Size(23, 23);
            this.ItemButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ItemButton.Location = new System.Drawing.Point(0, 162);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ItemButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ItemButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Item;
            this.ItemButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.ItemButton.Size = new System.Drawing.Size(200, 54);
            this.ItemButton.TabIndex = 3;
            this.ItemButton.Text = "Items";
            this.ItemButton.TextOffsetX = 10;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.AnimationHoverSpeed = 0.07F;
            this.CustomerButton.AnimationSpeed = 0.03F;
            this.CustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomerButton.BaseColor = System.Drawing.Color.Transparent;
            this.CustomerButton.BorderColor = System.Drawing.Color.Black;
            this.CustomerButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.CustomerButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CustomerButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CustomerButton.CheckedForeColor = System.Drawing.Color.White;
            this.CustomerButton.CheckedImage = global::Olis_Knitting_New_UI.Properties.Resources.Customer;
            this.CustomerButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CustomerButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CustomerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerButton.FocusedColor = System.Drawing.Color.Empty;
            this.CustomerButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.Color.Silver;
            this.CustomerButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Customer;
            this.CustomerButton.ImageSize = new System.Drawing.Size(23, 23);
            this.CustomerButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerButton.Location = new System.Drawing.Point(0, 108);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CustomerButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomerButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Customer;
            this.CustomerButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerButton.OnPressedColor = System.Drawing.Color.Black;
            this.CustomerButton.Size = new System.Drawing.Size(200, 54);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.TextOffsetX = 10;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.AnimationHoverSpeed = 0.07F;
            this.EmployeeButton.AnimationSpeed = 0.03F;
            this.EmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeButton.BaseColor = System.Drawing.Color.Transparent;
            this.EmployeeButton.BorderColor = System.Drawing.Color.Black;
            this.EmployeeButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.EmployeeButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmployeeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.EmployeeButton.CheckedForeColor = System.Drawing.Color.White;
            this.EmployeeButton.CheckedImage = global::Olis_Knitting_New_UI.Properties.Resources.Emps;
            this.EmployeeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EmployeeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeButton.FocusedColor = System.Drawing.Color.Empty;
            this.EmployeeButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.Silver;
            this.EmployeeButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Emps;
            this.EmployeeButton.ImageSize = new System.Drawing.Size(23, 23);
            this.EmployeeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EmployeeButton.Location = new System.Drawing.Point(0, 54);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EmployeeButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmployeeButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Emps;
            this.EmployeeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EmployeeButton.OnPressedColor = System.Drawing.Color.Black;
            this.EmployeeButton.Size = new System.Drawing.Size(200, 54);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.TextOffsetX = 10;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AnimationHoverSpeed = 0.07F;
            this.HomeButton.AnimationSpeed = 0.03F;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BaseColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.HomeButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.HomeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.HomeButton.CheckedForeColor = System.Drawing.Color.White;
            this.HomeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.CheckedImage")));
            this.HomeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FocusedColor = System.Drawing.Color.Empty;
            this.HomeButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Silver;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageSize = new System.Drawing.Size(23, 23);
            this.HomeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.OnHoverImage")));
            this.HomeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.HomeButton.OnPressedColor = System.Drawing.Color.Black;
            this.HomeButton.Size = new System.Drawing.Size(200, 54);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextOffsetX = 10;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AnimationHoverSpeed = 0.07F;
            this.MinimizeButton.AnimationSpeed = 0.03F;
            this.MinimizeButton.BaseColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MinimizeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.CheckedForeColor = System.Drawing.Color.White;
            this.MinimizeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.CheckedImage")));
            this.MinimizeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Minimize;
            this.MinimizeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MinimizeButton.LineColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Location = new System.Drawing.Point(1329, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MinimizeButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Minimize;
            this.MinimizeButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizeButton.Size = new System.Drawing.Size(40, 33);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.AnimationHoverSpeed = 0.07F;
            this.MaximizeButton.AnimationSpeed = 0.03F;
            this.MaximizeButton.BaseColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.BorderColor = System.Drawing.Color.Black;
            this.MaximizeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MaximizeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MaximizeButton.CheckedForeColor = System.Drawing.Color.White;
            this.MaximizeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.CheckedImage")));
            this.MaximizeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MaximizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.MaximizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.Maximize;
            this.MaximizeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaximizeButton.ImageSize = new System.Drawing.Size(17, 17);
            this.MaximizeButton.LineColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.Location = new System.Drawing.Point(1369, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MaximizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MaximizeButton.OnHoverImage = global::Olis_Knitting_New_UI.Properties.Resources.Maximize;
            this.MaximizeButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.MaximizeButton.Size = new System.Drawing.Size(40, 33);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.CheckedImage")));
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(1409, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.OnHoverImage")));
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(40, 33);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FormDragControl
            // 
            this.FormDragControl.TargetControl = this.FormPanel;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1451, 774);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.FormPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1379, 715);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private Guna.UI.WinForms.GunaAdvenceButton MinimizeButton;
        private Guna.UI.WinForms.GunaAdvenceButton MaximizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NavPanel;
        private Guna.UI.WinForms.GunaAdvenceButton HomeButton;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI.WinForms.GunaAdvenceButton EmployeeButton;
        private Guna.UI.WinForms.GunaAdvenceButton CustomerButton;
        private Guna.UI.WinForms.GunaAdvenceButton ItemButton;
        private Guna.UI.WinForms.GunaAdvenceButton SettingButton;
        private Guna.UI.WinForms.GunaAdvenceButton OrderButton;
        private Guna.UI.WinForms.GunaDragControl FormDragControl;
    }
}

