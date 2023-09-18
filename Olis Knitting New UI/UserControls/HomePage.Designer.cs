namespace Olis_Knitting_New_UI.UserControls
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBy = new Guna.UI.WinForms.GunaComboBox();
            this.SearchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.SearchBy);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 58);
            this.panel1.TabIndex = 16;
            // 
            // SearchBy
            // 
            this.SearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchBy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBy.BorderSize = 1;
            this.SearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchBy.DropDownHeight = 108;
            this.SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBy.FocusedColor = System.Drawing.Color.Empty;
            this.SearchBy.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBy.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchBy.FormattingEnabled = true;
            this.SearchBy.IntegralHeight = false;
            this.SearchBy.ItemHeight = 34;
            this.SearchBy.Items.AddRange(new object[] {
            "Search By Customer Name",
            "Search By Item Type"});
            this.SearchBy.Location = new System.Drawing.Point(634, 9);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchBy.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBy.Size = new System.Drawing.Size(236, 40);
            this.SearchBy.StartIndex = 0;
            this.SearchBy.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.AnimationHoverSpeed = 0.07F;
            this.SearchButton.AnimationSpeed = 0.03F;
            this.SearchButton.BaseColor = System.Drawing.Color.Transparent;
            this.SearchButton.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SearchButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.CheckedImage")));
            this.SearchButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchButton.FocusedColor = System.Drawing.Color.Empty;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.icons8_search_48px;
            this.SearchButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchButton.Location = new System.Drawing.Point(1196, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SearchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchButton.OnHoverImage = null;
            this.SearchButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchButton.Size = new System.Drawing.Size(45, 45);
            this.SearchButton.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.LightGray;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.LineColor = System.Drawing.Color.Gray;
            this.txtSearch.LineSize = 2;
            this.txtSearch.Location = new System.Drawing.Point(893, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(297, 41);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1249, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox SearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton SearchButton;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
