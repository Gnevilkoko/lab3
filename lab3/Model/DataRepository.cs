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
            Dishes[] dishes = (Dishes[]) Enum.GetValues(typeof(Dishes));

            for(int i = 0; i < sizes.Length; i++)
            {
                DishesSizePairs.Add(dishes[i], sizes[i]);
            }     
        }

        public void setDrinks(double[] percents)
        {
            Drinks[] drinks = (Drinks[]) Enum.GetValues(typeof(Drinks));

            for(int i = 0; i < percents.Length; i++)
            {
                DrinksSpirytusPairs.Add(drinks[i], percents[i]);
            }

        }
    }
}
