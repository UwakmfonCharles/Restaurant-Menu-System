using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    /// <summary>
    ///  this class shows us a burger item in the menu, this encapsulate the recipe, garnishes, and functions to add or remove garnishes. The constructor that initializes the burger with what recipe is needed, sets a base price and adds a default garnish for the recipe. The class provides the method to add or remove the garnish. THe calculated price method also finds the total price of the burger, + the additional chargest for the garnishes.
    /// </summary>
    public class Burger : FoodItem
    {
        private BurgerRecipe recipe;
        private List<Garnish> garnishes = new List<Garnish>();
        public List<Burger> burgers = new List<Burger>();

        public Burger() { }

        public Burger(BurgerRecipe recipe)
        {
            this.recipe = recipe;
            this.BasePrice = recipe.BasePrice;
            this.garnishes.AddRange(recipe.Garnishes);
        }

        public List<Garnish> Garnishes
        {
            get { return new List<Garnish>(garnishes); }
        }
        public void AddBurger(Burger burger)
        {
            burgers.Add(burger);
        }

        public void AddGarnish(Garnish garnish)
        {
            garnishes.Add(garnish);
        }

        public void RemoveGarnish(Garnish garnish)
        {
            garnishes.Remove(garnish);
        }

        public override decimal CalculatedPrice()
        {
            decimal price = BasePrice;
            foreach (var garnish in garnishes)
            {
                price += garnish.AdditionalCharge;
            }
            return price;
        }
    }


}
