using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class MemberDetail : Form
    {
          
        public MemberDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOfUpdate { get; set; }
        public MemberObject MemInfo { get; set; }
        private void MemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOfUpdate;
            if (InsertOfUpdate == true)
            {
                txtMemberID.Text = MemInfo.MemberID.ToString();
                txtMemberName.Text = MemInfo.MemberName.ToString();
                txtEmailChange.Text = MemInfo.Email.ToString();
                txtDateOfBirth.Value = MemInfo.DateOfBirth;
                txtCountry.Text = MemInfo.Country.ToString();
                txtCity.Text = MemInfo.City.ToString();
                txtPasswordChange.Text = MemInfo.Password.ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmailChange.Text,
                    DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPasswordChange.Text
                };
                if (InsertOfUpdate == false) {
                    
                        MemberRepository.InsertMember(mem);

                    } 
                else
                    {
                    MemberRepository.UpdateMember(mem);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOfUpdate == false ? "Add new member" : "Update member");
            }
            }
        }
    }

