using lab3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class SpirytusForm : Form
    {
        private ViewModel _viewModel;
        public SpirytusForm()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(610, Height);

            ResultData result = _viewModel.ClickGO(this.dishSizeBox.Text, this.spirytusBox.Text, this.dishesQuantityBox.Text);

            if(result == null)
            {
                MessageBox.Show(
                    "Please, write correct data",
                    "Invalid Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            showResult(result);

        }

        private void showResult(ResultData result)
        {
            resultSizeBox.Text = result.ResultSize.ToString();
            spirytusSizeBox.Text = result.SpirytusSize.ToString();
        }
    }
}
