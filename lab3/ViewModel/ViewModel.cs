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

            double dishSize = ParseToSize(dishOrSize);
            double spirytusPercent = ParseToPercent(drinkOrPercent);
            int quantity = ParseToQuantity(dishesQuantity);

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
            return (double.TryParse(dishOrSize, out double size) && size > 0) ? size : -1;
        }

        private double ParseToPercent(String drinkOrPercent)
        {
            return (double.TryParse(drinkOrPercent, out double percent) && percent > 0) ? percent : -1;
        }

        private int ParseToQuantity(String dishesQuantity)
        {
            return int.TryParse(dishesQuantity, out int quantity) && quantity > 0 ? quantity : -1;
        }

        public double GetDishSize(Dishes dish)
        {
            _dataRepository.DishesSizePairs.TryGetValue(dish, out double size);
            return size;
        }

        public double GetSpirytusPercent(Drinks drink)
        {
            _dataRepository.DrinksSpirytusPairs.TryGetValue(drink, out double size);
            return size;
        }
    }
}
