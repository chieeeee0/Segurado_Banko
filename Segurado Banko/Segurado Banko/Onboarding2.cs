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
    public partial class Onboarding2 : Form
    {
        public Onboarding2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onboarding3 onboard3 = new Onboarding3();
            onboard3.Show();
            this.Hide();
        }
    }
}
