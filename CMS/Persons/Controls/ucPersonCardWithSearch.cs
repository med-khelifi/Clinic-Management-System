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
            ucPersonCard1.LoadPersonInfo(txtSearchBox.Text);
            OnSearchPersonClicked?.Invoke(this, ucPersonCard1.NationalNo);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.OnSaveClicked += 
            (string NationalNo) =>
            {
                ucPersonCard1.LoadPersonInfo(NationalNo);
                OnSearchPersonClicked?.Invoke(this, NationalNo);
                txtSearchBox.Text = NationalNo;
            };
            frm.ShowDialog();
        }

        private void ucPersonCard1_Load(object sender, EventArgs e)
        {

        }
        public void EnableSearchBox()
        {
            EnableSearch = true;
        }
        public void DisableSearchBox()
        {
            EnableSearch = false;
        }
        public void LoadPersonInfo(string nationalNo)
        {
            ucPersonCard1.LoadPersonInfo(nationalNo);
            DisableSearchBox();
        }
    }
}
