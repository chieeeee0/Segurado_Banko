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
    public partial class Onboarding1 : Form
    {
        public Onboarding1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onboarding2 onboard2 = new Onboarding2();
            onboard2.Show();
            this.Hide();
        }
    }
}
