using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddGroupFriend : Form
    {
        public AddGroupFriend()
        {
            InitializeComponent();

            inputId.Leave += new EventHandler(inputId_Leave);
        }

        private void inputId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputId.Text))
            {
                inputId.Text = "Id를 입력하세요.";
                inputId.ForeColor = Color.White;
            }
        }
    }
}
