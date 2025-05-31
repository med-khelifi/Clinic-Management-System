using BusinessLayer;
using CMS.Users.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Doctors.Contorls
{
    public partial class ucShortDoctorCard : UserControl
    {
        clsDoctor _Doctor;
        private int _DoctorID;
        public int DoctorID
        {
            get { return _DoctorID; }
            set { _DoctorID = value; }
        }
        public clsDoctor DoctorInfo
        {
            get { return _Doctor; }
        }
        
        public ucShortDoctorCard()
        {
            InitializeComponent();
        }

        public void LoadDoctorInfo(string userName)
        {
            _Doctor = clsDoctor.FindByUsername(userName);
            if (_Doctor != null)
            {
                _LoadInfo();
            }
            else
            {
                ResetUserInfo();
                MessageBox.Show("No Doctor found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LoadDoctorInfo(clsDoctor Doctor)
        {
            _Doctor = Doctor;
            if (_Doctor != null)
            {
                _LoadInfo();
            }
            else
            {
                ResetUserInfo();
                MessageBox.Show("No Doctor found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResetUserInfo()
        {
            _DoctorID = -1;
            lblspecializationValue.Text = "-";
            ucPersonCard1.ResetPersonInfo();
        }
        private void _LoadInfo()
        {
            _DoctorID = _Doctor.DoctorID;
            lblspecializationValue.Text = _Doctor.Specialization;
            ucPersonCard1.LoadPersonInfo(_Doctor.UserInfo.PersonInfo);
        }
    }
}
