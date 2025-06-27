using BusinessLayer;
using CMS.GlobalClasses;
using CMS.MediicalRecords.Controls;
using CMS.Patients;
using CMS.Properties;
using CMS.Users;
using CMS.Utility;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        void SetButtonsLayout()
        {
            if (clsGlobal.CurrentUser is clsUser user && user.RoleId == (int)clsUser.enRoles.admin) return;

            foreach (Guna2Button item in flpPanel.Controls)
            {
                item.Visible = false;
            }

            btnDashbord.Visible = true;
            flpPanel.Controls.SetChildIndex(btnDashbord, 0);

            if(clsGlobal.CurrentUser is clsDoctor)
            {
                btnAppointements.Visible = true;
                btnMedicalRecords.Visible = true;
                

                flpPanel.Controls.SetChildIndex(btnAppointements, 1);
                flpPanel.Controls.SetChildIndex(btnMedicalRecords, 2);
               
            }
            else
            {
                flpPanel.Controls.SetChildIndex(btnPatients, 1);
                flpPanel.Controls.SetChildIndex(btnAppointements, 2);
                flpPanel.Controls.SetChildIndex(btnMedicalRecords, 3);
                flpPanel.Controls.SetChildIndex(btnPayments, 4);
                

                btnPatients.Visible = true;
                btnAppointements.Visible = true;
                btnMedicalRecords.Visible = true;
                btnPayments.Visible = true;
               

                
            }
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            var uc = new Dashboard.ucDashbord();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            var uc = new Users.Controls.ucManageUsers();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            var uc = new Doctors.Controls.ctrManageDoctors();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void btnPatients_Click(object sender, EventArgs e)
        {
            var uc = new Patients.Controls.ctrManagePatiants();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void btnAppointements_Click(object sender, EventArgs e)
        {
            var uc = new Appointments.Controls.ucManageAppointments();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            var uc = new ucManagePayments();
            clsUtil.ShowUserControl(uc, pMain);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetButtonsLayout();
            if(clsGlobal.CurrentUser is clsDoctor doctor)
            {
                _LoadUserImageImage(doctor.UserInfo.PersonInfo.ImagePath, doctor.UserInfo.PersonInfo.Gender);
            }
            if (clsGlobal.CurrentUser is clsUser user)
            {
                _LoadUserImageImage(user.PersonInfo.ImagePath, user.PersonInfo.Gender);
            }

            btnDashbord.PerformClick();
        }
        private void pbUserPicture_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pbUserPicture, new Point(0, pbUserPicture.Height));
        }
        private void _LoadUserImageImage(string ImagePath,bool gender)
        {
          
            if (string.IsNullOrEmpty(ImagePath))
            {
                pbUserPicture.Image = (gender == false ? Resources.Male : Resources.female);
                return;
            }
            if (File.Exists(ImagePath))
                pbUserPicture.ImageLocation = ImagePath;
            else
                MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void tsmShowUserDetails_Click(object sender, EventArgs e)
        {
            string userName = "";
            if(clsGlobal.CurrentUser is clsDoctor d)
            {
                userName = d.UserInfo.Username;
            } 
            if(clsGlobal.CurrentUser is clsUser u)
            {
                userName = u.Username;
            }
            if (string.IsNullOrEmpty(userName)) return;
            using(frmUserInfo frm = new frmUserInfo(userName))
            {
                frm.ShowDialog();
            }
        }
        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            string userName = "";
            if (clsGlobal.CurrentUser is clsDoctor d)
            {
                userName = d.UserInfo.Username;
            }
            if (clsGlobal.CurrentUser is clsUser u)
            {
                userName = u.Username;
            }
            if (string.IsNullOrEmpty(userName)) return;
            using (frmChangePassword frm = new frmChangePassword(userName))
            {
                frm.ShowDialog();
            }
        }
        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            Close();
        }

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            var uc = new ucManageMedicalRecords();
            clsUtil.ShowUserControl(uc, pMain);
        }
    }
}
