
namespace MyStoreWinApp
{
    partial class MemberDetail
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
            this.txtPasswordChange = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmailChange = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordChange
            // 
            this.txtPasswordChange.Location = new System.Drawing.Point(210, 431);
            this.txtPasswordChange.Name = "txtPasswordChange";
            this.txtPasswordChange.PasswordChar = '*';
            this.txtPasswordChange.Size = new System.Drawing.Size(250, 27);
            this.txtPasswordChange.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(210, 323);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 27);
            this.txtCity.TabIndex = 1;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(210, 124);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(250, 27);
            this.txtMemberID.TabIndex = 3;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(210, 173);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(250, 27);
            this.txtMemberName.TabIndex = 4;
            // 
            // txtEmailChange
            // 
            this.txtEmailChange.Location = new System.Drawing.Point(210, 221);
            this.txtEmailChange.Name = "txtEmailChange";
            this.txtEmailChange.Size = new System.Drawing.Size(250, 27);
            this.txtEmailChange.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(210, 379);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 27);
            this.txtCountry.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "MemberID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(210, 269);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(250, 27);
            this.txtDateOfBirth.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(76, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 574);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtEmailChange);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPasswordChange);
            this.Name = "MemberDetail";
            this.Text = "MemberDetail";
            this.Load += new System.EventHandler(this.MemberDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordChange;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtEmailChange;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}