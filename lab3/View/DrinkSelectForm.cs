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

namespace lab3.View
{
    public partial class DrinkSelectForm : Form
    {
        private SpirytusForm _spirytusForm;
        private TextBox _drinkSizeTextBox;
        private ViewModel _viewModel;

        public DrinkSelectForm(SpirytusForm spirytusForm, ViewModel viewModel, TextBox drinkSizeTextBox)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            this._spirytusForm = spirytusForm;
            this._drinkSizeTextBox = drinkSizeTextBox;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _spirytusForm.Show();

            base.OnFormClosed(e);


        }

        private void selectDishButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _spirytusForm.Show();
            _drinkSizeTextBox.Text = _viewModel.GetSpirytusPercent(GetSelectedDrink()).ToString();
        }

        private Drinks GetSelectedDrink()
        {
            if (vodkaRadioButton.Checked)
                return Drinks.Vodka;
            else if (wineRadioButton.Checked)
                return Drinks.Wine;
            else
                return Drinks.Whiskey;
        }
    }
}
