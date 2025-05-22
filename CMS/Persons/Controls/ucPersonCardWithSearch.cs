using BusinessLayer;
using CMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Persons.Controls
{
    public partial class ucPersonCardWithSearch : UserControl
    {
        public delegate void SearchPersonHandler(object sender,string nationalNo);
        public event SearchPersonHandler OnSearchPersonClicked;
        bool _EnableSearch;
        public bool EnableSearch
        {
            get
            {
                return _EnableSearch;
            }
            set
            {
                _EnableSearch = value;
                gbFilter.Enabled = value;
            }
        }
        public string NationalNoSearchText
        {
            set
            {
                txtSearchBox.Text = value;
            }
        }
        public string NationalNo
        {
            get
            {
                return ucPersonCard1.NationalNo;
            }
        }
        public clsPerson PersonInfo
        {
            get
            {
                return ucPersonCard1.PersonInfo;
            }
        }
        public ucPersonCardWithSearch()
        {
            InitializeComponent();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                MessageBox.Show("Please enter a National No to search.","Empty Box",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //ucPersonCard1.LoadPersonInfo(txtSearchBox.Text);
            OnSearchPersonClicked?.Invoke(this, txtSearchBox.Text);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.OnUserSaved += (person) =>
            {
                txtSearchBox.Text = person.NationalNo;
                EnableSearch = false;
                ucPersonCard1.LoadPersonInfo(person);
            };
            frm.ShowDialog();
        }

        private void ucPersonCard1_Load(object sender, EventArgs e)
        {

        }
        ////public void EnableSearchBox()
        ////{
        ////    EnableSearch = true;
        ////}
        ////public void DisableSearchBox()
        ////{
        ////    EnableSearch = false;
        ////}
        public void LoadPersonInfo(clsPerson Person)
        {
            if (Person == null)
            {
                MessageBox.Show("No Person Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCard1.ResetPersonInfo();    
                return;
            }
            ucPersonCard1.LoadPersonInfo(Person);
            llEditPerson.Visible = true;
            EnableSearch = false;
        }

        public void LoadPersonInfo(string NationalNo)
        {
            clsPerson Person = clsPerson.Find(NationalNo);
            if (Person == null)
            {
                MessageBox.Show("No Person Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCard1.ResetPersonInfo();
                return;
            }
            ucPersonCard1.LoadPersonInfo(Person);
            llEditPerson.Visible = true;
        }

        public void ResetPersonInfo()
        {

            ucPersonCard1.ResetPersonInfo();
            llEditPerson.Visible = false;   
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(frmAddEditPerson frm = new frmAddEditPerson(ucPersonCard1.PersonInfo.NationalNo))
            {
                frm.OnUserSaved += (person) =>
                {
                    txtSearchBox.Text = person.NationalNo;
                    EnableSearch = false;
                    ucPersonCard1.LoadPersonInfo(person);
                };
                frm.ShowDialog();
            }
        }
    }
}
