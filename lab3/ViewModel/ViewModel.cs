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

        public ResultData ClickGO(object dishOrSize, object drinkOrPercent, object dishesQuantity)
        {

            double dishSize = GetDishSize(dishOrSize);
            double spirytusPercent = GetSpirytusPercent(drinkOrPercent);
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

        public double GetDishSize(object dish)
        {
            if (double.TryParse(dish.ToString(), out double size) && size > 0)
            {
                return size;
            }
            else if (dish.GetType() == typeof(Dishes))
            {
                _dataRepository.DishesSizePairs.TryGetValue((Dishes)dish, out size);
                return size;
            } else
            {
                return -1;
            }
        }

        public double GetSpirytusPercent(object drink)
        {
            if (double.TryParse(drink.ToString(), out double percent) && percent > 0)
            {
                return percent;
            }
            else if(drink.GetType() == typeof(Drinks))
            {
                _dataRepository.DrinksSpirytusPairs.TryGetValue((Drinks)drink, out percent);
                return percent;
            } else
            {
                return -1;
            }
        }

        public int GetDishesQuantity(object quantity)
        {
            if(int.TryParse(quantity.ToString(), out int result) && (result > 0 && result <= 100))
            {
                return result;
            } else
            {
                return -1;
            }
        }
    }
}
