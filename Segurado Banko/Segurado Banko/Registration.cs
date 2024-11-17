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
    public partial class Registration : Form
    {
        BankAccount account = new BankAccount();
        public Registration(BankAccount account)
        {
            InitializeComponent();
            this.account = account;
        }

        public Registration()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount bAccount = new BankAccount();
            bAccount.Firstname = txtRegisterFirstname.Text;
            bAccount.Lastname = txtRegisterLastname.Text;
            bAccount.EmailAddress = txtRegisterEmailAddress.Text;
            bAccount.PINCode = txtRegisterPINCode.Text;


            if (account.VerifyRegisterPassword(txtRegisterPINCode.Text))
            {
                account.SetDefault(bAccount, txtRegisterEmailAddress.Text, txtRegisterPINCode.Text);
                if (!txtRegisterEmailAddress.Text.EndsWith("@gmail.com"))
                {
                    DialogResult dialog = MessageBox.Show("Please enter a valid Gmail address", "Error");
                    if (dialog == DialogResult.OK)
                    {
                        Login login = new Login(account);
                        login.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
