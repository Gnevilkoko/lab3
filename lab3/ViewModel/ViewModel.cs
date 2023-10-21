using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab3.Model;
using static System.Windows.Forms.LinkLabel;

namespace lab3
{
    class ViewModel
    {
        private DataRepository _dataRepository = new DataRepository();

        public ViewModel() 
        {
            _dataRepository.setDishes(new double[] {225, 295, 50});
            _dataRepository.setDrinks(new double[] {40, 15.25, 41.25});
        }

        public ResultData ClickGO(String dishOrSize, String drinkOrPercent, String dishesQuantity)
        {

            double dishSize = double.Parse(dishOrSize);
            double spirytusPercent = double.Parse(drinkOrPercent);
            int quantity = GetDishesQuantity(dishesQuantity);

            if(dishSize == -1 || spirytusPercent == -1 || quantity == -1)
            {
                return null;
            } else
            {
                return new ResultData(
                dishSize * quantity,
                (dishSize * quantity) * spirytusPercent / 100
                );
            }

            
        }
        private double ParseToSize(String dishOrSize)
        {
            double.TryParse(dishOrSize, out double size) && size > 0 ? return size; : return -1;
        }

        private double ParseToPercent(String dishOrSize)
        {
            double.TryParse(drink.ToString(), out double percent) && percent > 0 ? return percent; : return -1;
        }

        public double GetDishSize(Dishes dish)
        {
            _dataRepository.DishesSizePairs.TryGetValue((Dishes)dish, out double size);
            return size;
        }

        public double GetSpirytusPercent(Drinks drink)
        {
            _dataRepository.DrinksSpirytusPairs.TryGetValue((Dishes)dish, out double size);
            return size;
        }
    }
}
