using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Patients.Controls
{
    public partial class ucPatientCard : UserControl
    {
        clsPatient _patient;
        public ucPatientCard()
        {
            InitializeComponent();
        }
        public void LoadPatientData(clsPatient patient)
        {
            _patient = patient;
            if (_patient != null)
            {
                _loadData();
            }
            else
            {
                MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadPatientData(string nationalNo)
        {
            _patient = clsPatient.FindByNationalNo(nationalNo);
            if (_patient != null)
            {
                _loadData();
            }
            else
            {
                MessageBox.Show("Patient not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void _loadData()
        {
            ucPersonCard1.LoadPersonInfo(_patient.PersonInfo);
            lblBloodType.Text = _patient.BloodTypeInfo.BloodTypeName;
        }
        public void ResetPatientInfo()
        {
            _patient = null;
            ucPersonCard1.ResetPersonInfo();
            lblBloodType.Text = "-";
        }
    }
}
