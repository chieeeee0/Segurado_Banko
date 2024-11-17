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
    public partial class Opening : Form
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onboarding1 onboard1 = new Onboarding1();
            onboard1.Show();
            this.Hide();
        }
    }
}
