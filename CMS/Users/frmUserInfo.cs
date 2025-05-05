using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Users
{
    public partial class frmUserInfo : Form
    {
        string _username;
        public frmUserInfo(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ucUserCard1.LoadUserInfo(_username);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
