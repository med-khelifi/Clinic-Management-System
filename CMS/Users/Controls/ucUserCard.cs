using BusinessLayer;
using CMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Users.Controls
{
    public partial class ucUserCard : UserControl
    {
        clsUser _user;
        int _UserID;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public clsUser User
        {
            get { return _user; }
        }

        public ucUserCard()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(string userName) 
        {
            _user = clsUser.Find(userName);
            if (_user != null)
            {
                _LoadInfo();
            }
            else
            {
                ResetUserInfo();
                MessageBox.Show("No User found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void ResetUserInfo()
        {
            _UserID = -1;
            lblisActive.Text = "No";
            lblUsername.Text = "-";
            lblRole.Text = "-";
            ucPersonCard1.ResetPersonInfo();
        }
        private void _LoadInfo()
        {
            _UserID = _user.UserId;
            lblisActive.Text = _user.IsActive ? "Yes" : "No";
            lblUsername.Text = _user.Username;
            lblRole.Text = _user.RoleInfo.RoleName;
            ucPersonCard1.LoadPersonInfo(_user.PersonInfo);
        }
    }
}
