using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab3.Model;

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

        private double GetDishSize(object dish)
        {
            if (dish.GetType() == typeof(double))
            {
                return (double)dish;
            }
            else if (dish.GetType() == typeof(Dishes))
            {
                double size;
                _dataRepository.DishesSizePairs.TryGetValue((Dishes)dish, out size);
                return size;
            } else
            {
                return -1;
            }
        }

        private double GetSpirytusPercent(object drink)
        {
            if (drink.GetType() == typeof(double))
            {
                return (double)drink;
            }
            else if(drink.GetType() == typeof(Drinks))
            {
                double size;
                _dataRepository.DrinksSpirytusPairs.TryGetValue((Drinks)drink, out size);
                return size;
            } else
            {
                return -1;
            }
        }

        private int GetDishesQuantity(object quantity)
        {
            if(quantity.GetType() == typeof(int))
            {
                return (int)quantity;
            } else
            {
                return -1;
            }
        }
    }
}
