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
    public partial class load : Form
    {
        BankAccount account;
        public load(BankAccount account)
        {
            InitializeComponent();


            timer1.Start();
            this.account = account;
        }
        public load()
        {
            
        }
        int progressbarValue = 0;
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoad.Text = progressBar1.Value.ToString();
            if (progressBar1.Value < 20 )
            {
                if (progressBar1.Value != 100)
                {
                    progressBar1.Value += 2;
                }
            }
            else if (progressBar1.Value >= 20 )
            {
                if(progressBar1.Value != 100)
                {
                    progressBar1.Value += 10;
                }
                else
                {
                    HomeScreen homescreen = new HomeScreen();
                    homescreen.Show();
                    this.Hide();
                    timer1.Stop();

                }
            }
            
        }
    }
}
