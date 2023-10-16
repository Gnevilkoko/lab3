using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ResultData ClickGO(object dish, object drink, int dishesQuantity)
        {

            double dishSize = GetDishSize(dish);
            double spirytusPercent = GetSpirytusPercent(drink);

            double resultSize = dishSize * dishesQuantity;
            double spirytusSize = resultSize * spirytusPercent / 100;

            return new ResultData(resultSize, spirytusSize);
        }

        private double GetDishSize(object dish)
        {
            if (dish.GetType() == typeof(double))
            {
                return (double)dish;
            }
            else
            {
                double size;
                _dataRepository.DishesSizePairs.TryGetValue((Dishes)dish, out size);
                return size;
            }
        }

        private double GetSpirytusPercent(object drink)
        {
            if (drink.GetType() == typeof(double))
            {
                return (double)drink;
            }
            else
            {
                double size;
                _dataRepository.DrinksSpirytusPairs.TryGetValue((Drinks)drink, out size);
                return size;
            }
        }
    }
}
