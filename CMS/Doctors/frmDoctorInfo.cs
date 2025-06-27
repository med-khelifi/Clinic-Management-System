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
        string _nationalNo;   
        public frmDoctorInfo(string NationalNo)
        {
            InitializeComponent();
            _nationalNo = NationalNo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoctorInfo_Load(object sender, EventArgs e)
        {
            ucDoctorCard1.LoadDoctorInfoByNationalNo(_nationalNo);
        }
    }
}
