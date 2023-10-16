using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Model
{

    class DataRepository
    {
        public Dictionary<Dishes, double> DishesSizePairs = new Dictionary<Dishes, double>();
        public Dictionary<Drinks, double> DrinksSpirytusPairs = new Dictionary<Drinks, double>();

        public DataRepository() { }

        public void setDishes(double[] sizes)
        {
            foreach (var dishSize in sizes)
            {
                foreach(Dishes dish in Enum.GetValues(typeof(Dishes)))
                {
                    DishesSizePairs.Add(dish, dishSize);
                }
            }
        }

        public void setDrinks(double[] percents)
        {
            foreach(var spirytusPercent in percents)
            {
                foreach (Drinks drink in Enum.GetValues(typeof(Drinks)))
                {
                    DrinksSpirytusPairs.Add(drink, spirytusPercent);
                }
            }
        }
    }
}
