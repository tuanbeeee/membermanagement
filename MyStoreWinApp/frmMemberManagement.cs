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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemList.CellDoubleClick += DgvMemList_CellDoubleClick;
        }

        private void DgvMemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberDetail frmMemDetails = new MemberDetail
            {
                Text = "Update Member",
                InsertOfUpdate = true,
                MemInfo = GetMemberObject(),
                MemberRepository = memberRepository

            };
            if (frmMemDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemList();
                //Set focus car update
                source.Position = source.Count - 1;
            }
        }

        public void LoadMemList()
        {
            var mem = memberRepository.GetMemberObjects();
            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = mem;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;
                dgvMemList.DataSource = source;

                if (mem.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        public void SortByName()
        {
            var mem = memberRepository.GetMemberObjects();
            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = mem.OrderByDescending(n => n.MemberName);

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;
                dgvMemList.DataSource = source;

                if (mem.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }
        private void SearchMemberByName(string SearchName)
        {
            var mem = memberRepository.GetMemberObjects();
      
            //vong for;
            //ssanh = ten: foreach member in mem
            //member.Contains(keyword)
            //list.Add(member)
            List<MemberObject> list = new List<MemberObject>();
            foreach (var member in mem)
            {
                if (member.MemberName.Contains(SearchName))
                {
                    list.Add(member);
                }
                                          
            }            
            try
            {
                source = new BindingSource();
                source.DataSource = list;
                

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;
                

                if (list.Count() == 0)
                {
                    
                    ClearText();
                    btnDelete.Enabled = false;
                    
                   
                }
                else
                {
                    dgvMemList.DataSource = source;
                    btnDelete.Enabled = true;
                    
                }
            }
            catch
            {
                MessageBox.Show("Sai roi");
            }
            
        }

        private void FilterByCity(string SearchName)
        {
            var mem = memberRepository.GetMemberObjects();

            //vong for;
            //ssanh = ten: foreach member in mem
            //member.Contains(keyword)
            //list.Add(member)
            List<MemberObject> list = new List<MemberObject>();
            foreach (var member in mem)
            {
                if (member.City.Contains(SearchName))
                {
                    list.Add(member);
                }

            }
            try
            {
                source = new BindingSource();
                source.DataSource = list;


                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;


                if (list.Count() == 0)
                {

                    ClearText();
                    btnDelete.Enabled = false;


                }
                else
                {
                    dgvMemList.DataSource = source;
                    btnDelete.Enabled = true;

                }
            }
            catch
            {
                MessageBox.Show("Sai roi");
            }

        }

        private void FilterByCountry(string SearchName)
        {
            var mem = memberRepository.GetMemberObjects();

            //vong for;
            //ssanh = ten: foreach member in mem
            //member.Contains(keyword)
            //list.Add(member)
            List<MemberObject> list = new List<MemberObject>();
            foreach (var member in mem)
            {
                if (member.Country.Contains(SearchName))
                {
                    list.Add(member);
                }

            }
            try
            {
                source = new BindingSource();
                source.DataSource = list;


                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;


                if (list.Count() == 0)
                {

                    ClearText();
                    btnDelete.Enabled = false;


                }
                else
                {
                    dgvMemList.DataSource = source;
                    btnDelete.Enabled = true;

                }
            }
            catch
            {
                MessageBox.Show("Sai roi");
            }

        }
        private void SearchMemberByID(int SearchName)
        {
            var mem = memberRepository.GetMemberObjects();
            //vong for;
            //ssanh = ten: foreach member in mem
            //member.Contains(keyword)
            //list.Add(member)
            var acc = mem.SingleOrDefault(pro => pro.MemberID == SearchName);
            try
            {
                source = new BindingSource();
                source.DataSource = acc;


                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDateOfBirth.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDateOfBirth.DataBindings.Add("Text", source, "DateOfBirth");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemList.DataSource = null;
                

                if (acc == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    
                }
                else
                {
                    dgvMemList.DataSource = source;
                    btnDelete.Enabled = true;
                    
                }
            }
            catch
            {
                MessageBox.Show("Sai roi");
            }
            
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        public MemberObject GetMemberObject()
        {
            MemberObject mem = null;
            try
            {
                mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return mem;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemList();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            
            frmLogin login = new frmLogin();
            this.Hide(); 
            login.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberDetail frmMemberManagement = new MemberDetail
            {
                Text = "Add new member",
                InsertOfUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberManagement.ShowDialog() == DialogResult.OK)
            {
                LoadMemList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = GetMemberObject();
                memberRepository.DeleteMember(mem.MemberID);
                LoadMemList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete one member");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text.Equals("ID") )
            {
                try
                {
                    SearchMemberByID(int.Parse(searchName.Text));
                }
                catch
                {
                    MessageBox.Show("Nothing to show");
                }
            } else if (cbSearch.Text.Equals("Name"))
            {
                try
                {
                    SearchMemberByName(searchName.Text);
                }
                catch
                {
                    MessageBox.Show("Nothing to show");
                }
            }
            
            
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cbFilter.Text = cbFilter.GetItemText(cbFilter.SelectedItem);
            if (cbFilter.Text.Equals("City"))
            {
                try
                {
                    FilterByCity(cbChoose.Text);
                }
                catch
                {
                    MessageBox.Show("Nothing to show");
                }
            }
            else if (cbFilter.Text.Equals("Country"))
            {
                try
                {
                    FilterByCountry(cbChoose.Text);
                }
                catch
                {
                    MessageBox.Show("Nothing to show");
                }
            }
        }

        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {


            cbFilter.Text = cbFilter.GetItemText(cbFilter.SelectedItem);
            if (cbFilter.Text.Equals("City"))
            {
                cbChoose.Items.Clear();
                cbChoose.Items.Add("HCM");
                cbChoose.Items.Add("HN");
                cbChoose.Items.Add("BRVT");
                cbChoose.Items.Add("LA");
                cbChoose.Items.Add("BD");


            } else if (cbFilter.Text.Equals("Country"))
            {
                cbChoose.Items.Clear();
                cbChoose.Items.Add("VN");
                cbChoose.Items.Add("CAM");
                
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortByName();
        }
    }
}
