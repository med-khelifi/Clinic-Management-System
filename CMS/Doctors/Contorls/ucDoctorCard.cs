using BusinessLayer;
using CMS.Users.Controls;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ucDoctorCard : UserControl
    {
        clsDoctor _Doctor;
        private int _DoctorID;
        public int DoctorID
        {
            get { return _DoctorID; }
            set { _DoctorID = value; }
        }
        public clsDoctor Doctor
        {
            get { return _Doctor; }
        }
        public ucDoctorCard()
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
            lblspecialization.Text = "-";
            ucUserCard1.ResetUserInfo();
        }
        private void _LoadInfo()
        {
            _DoctorID = _Doctor.DoctorID;
            lblspecializationValue.Text = _Doctor.Specialization;    
            ucUserCard1.LoadUserInfo(_Doctor.UserInfo);
        }
    }
}
