using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3.View
{
    public partial class DishSelectionScreen : Form
    {
        private SpirytusForm _spirytusForm;

        public DishSelectionScreen(SpirytusForm spirytusForm)
        {
            InitializeComponent();
            _spirytusForm = spirytusForm;
        }

        private void DishSelectionScreen_Closing(object sender, EventArgs e)
        {
            _spirytusForm.Show();
        }
    }
}
