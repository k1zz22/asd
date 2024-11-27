using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class FemaleShsForm : Form
    {
        string category;
        char gender;

        public FemaleShsForm(string category, char gender)
        {
            this.gender = gender;
            this.category = category;
            InitializeComponent();
        }

        private void SHSMenPantsImage_Click(object sender, EventArgs e)
        {

        }
    }
}
