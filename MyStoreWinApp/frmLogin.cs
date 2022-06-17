using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);  // đọc text từ tập tin JSON

            // deserialize từ chuỗi đọc ở tập tin JSOn --> đối tượng DefaultAccount
            var adminAccount = JsonSerializer.Deserialize<MemberObject>(json, null);

            string email = adminAccount.Email;
            string password = adminAccount.Password;

            frmMemberManagement check = new frmMemberManagement();
            
            if (email.Equals(txtUserName.Text ) && password.Equals(txtPassword.Text)) { 
                frmMemberManagement login = new frmMemberManagement();
                login.Show();
                this.Hide();
            } else if (checkMember()!= null)
            {
                this.Hide();
                MemberDetail UserLogin = new MemberDetail
                    {
                        Text = "User Detail",
                        InsertOfUpdate = true,
                        MemInfo = checkMember(),
                        MemberRepository = memberRepository
                    };
                this.Hide();
                    if (UserLogin.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Change Successfully! Please Login Again!");
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    }
                
            }
            else
            {
                MessageBox.Show("Account is invalid !");

            }

        }
        private MemberObject checkMember()
        {
            var mem = memberRepository.GetMemberObjects();
            var acc = mem.SingleOrDefault(pro => pro.Email.Equals(txtUserName.Text) && pro.Password.Equals(txtPassword.Text));
            if (acc == null)
            {                
                return null;
            }else
            {
                return acc;
            }
        }
    }
}
