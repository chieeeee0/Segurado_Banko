using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segurado_Banko
{
    public partial class Login : Form
    {
        BankAccount account = null;
        public Login(BankAccount account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "1 ";
            txtTruePINCode.Text += "1";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "2 ";
            txtTruePINCode.Text += "2";
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "3 ";
            txtTruePINCode.Text += "3";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "4 ";
            txtTruePINCode.Text += "4";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "5 ";
            txtTruePINCode.Text += "5";
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "6 ";
            txtTruePINCode.Text += "6";
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "7 ";
            txtTruePINCode.Text += "7";
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "8 ";
            txtTruePINCode.Text += "8";
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "9 ";
            txtTruePINCode.Text += "9";
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            txtPINCode.Text += "0 ";
            txtTruePINCode.Text += "0";
        }

        private void txtTruePINCode_TextChanged(object sender, EventArgs e)
        {
            lblPINCode.Text = txtPINCode.Text;

            if (txtPINCode.TextLength == 2)
            {
                lblPINCode.Text += "• • •";
            }
            else if (txtPINCode.TextLength == 4)
            {
                lblPINCode.Text += "• •";
            }
            else if (txtPINCode.TextLength == 6)
            {
                lblPINCode.Text += "•";
            }
            else if (txtPINCode.TextLength == 8)
            {
                lblPINCode.Text += "";
            }
            else
            {
                lblPINCode.Text = "• • • •";
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPINCode.Text.Length > 0)
            {
                txtPINCode.Text = txtPINCode.Text.Substring(0, txtPINCode.Text.Length - 2);
                txtTruePINCode.Text = txtTruePINCode.Text.Substring(0, txtTruePINCode.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!account.LoginMethod(txtTruePINCode.Text))
            {
                DialogResult dialog = MessageBox.Show("Succesful Log in!", "Segurado Banko");
                if (dialog == DialogResult.OK)
                {
                    load load = new load(account);
                    load.Show();
                    this.Hide();
                }
            }
           
        }
    }
}
