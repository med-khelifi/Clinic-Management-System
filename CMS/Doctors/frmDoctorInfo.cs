using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Doctors
{
    public partial class frmDoctorInfo : Form
    {
        string _username;   
        public frmDoctorInfo(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoctorInfo_Load(object sender, EventArgs e)
        {
            ucDoctorCard1.LoadDoctorInfo(_username);
        }
    }
}
