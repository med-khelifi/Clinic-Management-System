using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Patients
{
    public partial class frmPatientInfo : Form
    {
        string _nationalNo;
        public frmPatientInfo(string nationalNo)
        {
            InitializeComponent();
            _nationalNo = nationalNo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            ucPatientCard1.LoadPatientData(_nationalNo);
        }
    }
}
