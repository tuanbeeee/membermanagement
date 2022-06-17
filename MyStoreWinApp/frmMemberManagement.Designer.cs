
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.dgvMemList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(221, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(168, 23);
            this.txtPassword.TabIndex = 0;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(640, 116);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(175, 23);
            this.txtDateOfBirth.TabIndex = 1;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(640, 82);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(175, 23);
            this.txtCountry.TabIndex = 2;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(221, 48);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(168, 23);
            this.txtMemberID.TabIndex = 3;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(221, 82);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(168, 23);
            this.txtMemberName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(221, 116);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(640, 48);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(175, 23);
            this.txtCity.TabIndex = 6;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(144, 50);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(63, 15);
            this.lbMemberID.TabIndex = 7;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(144, 84);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(39, 15);
            this.lbMemberName.TabIndex = 8;
            this.lbMemberName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(144, 118);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(144, 152);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(556, 50);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 11;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(556, 84);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Country";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(556, 118);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(69, 15);
            this.lbDateOfBirth.TabIndex = 13;
            this.lbDateOfBirth.Text = "DateOfBirth";
            // 
            // dgvMemList
            // 
            this.dgvMemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemList.Location = new System.Drawing.Point(10, 239);
            this.dgvMemList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemList.Name = "dgvMemList";
            this.dgvMemList.RowHeadersWidth = 51;
            this.dgvMemList.RowTemplate.Height = 29;
            this.dgvMemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemList.Size = new System.Drawing.Size(645, 184);
            this.dgvMemList.TabIndex = 14;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(46, 213);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 22);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 213);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 213);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(437, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(789, 242);
            this.searchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(121, 23);
            this.searchName.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(913, 240);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 24);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "City",
            "Country"});
            this.cbFilter.Location = new System.Drawing.Point(673, 285);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(110, 23);
            this.cbFilter.TabIndex = 23;
            this.cbFilter.SelectionChangeCommitted += new System.EventHandler(this.cbFilter_SelectionChangeCommitted);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(913, 284);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(82, 24);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbChoose
            // 
            this.cbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(789, 284);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(121, 23);
            this.cbChoose.TabIndex = 25;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbSearch.Location = new System.Drawing.Point(673, 242);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(110, 23);
            this.cbSearch.TabIndex = 26;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(673, 327);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(322, 45);
            this.btnSort.TabIndex = 27;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 432);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMemList);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtPassword);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMemberManagement";
            this.Text = "MemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.DataGridView dgvMemList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbChoose;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnSort;
    }
}