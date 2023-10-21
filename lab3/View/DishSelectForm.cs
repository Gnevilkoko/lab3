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
    public partial class DishSelectForm : Form
    {
        private SpirytusForm _spirytusForm;
        private TextBox _dishSizeTextBox;
        private ViewModel _viewModel;

        public DishSelectForm(SpirytusForm spirytusForm)
        {
            InitializeComponent();
            this._spirytusForm = spirytusForm;
        }

        private void mugRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _spirytusForm.Show();

            base.OnFormClosed(e);


        }

        private void selectDishButton_Click(object sender, EventArgs e)
        {
            _spirytusForm.Show();
            Dishes dishes = GetSelectedDish();
            Console.WriteLine(dishes);
            double penis = _viewModel.GetDishSize(Dishes.Mug);
            Console.WriteLine(penis);
            //_dishSizeTextBox.Text = _viewModel.GetDishSize(GetSelectedDish()).ToString();

        }

        private Dishes GetSelectedDish()
        {
            if (mugRadioButton.Checked)
                return Dishes.Mug;
            else if(glassRadioButton.Checked) 
                return Dishes.Glass;
            else
                return Dishes.Shot;
        }
    }
}
