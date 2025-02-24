using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{

    /// <summary>
    ///  the menu class manages a list of fooditem objects, which includes pizza and burgers instances
    ///  it provides methods to display the menu with item names and prices, and can retrive the list of menu items
    ///  the class includes a default initializer so the menu with the predefined items and an overload constructor for custom menu item lists.
    /// </summary>
    public class Menu
    {
        private List<FoodItem> foodItems;

        public Menu()
        {
            foodItems = new List<FoodItem>()


            {
                new Pizza(new PizzaRecipe("Margherita",
                new List<Topping> { new Topping("Tomato Sauce", 0), new Topping("Cheese", 0) }, 8)),
                new Burger (new BurgerRecipe("Cheese Burger",
                new List<Garnish> { new Garnish("Cheese", 0) }, 5))
            };
        }

        public Menu(List<FoodItem> foodItems)
        {
            this.foodItems = foodItems;
            
        }
        
        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var item in foodItems)
            {
                Console.WriteLine($"{item.Name} - {item.BasePrice:C}");
            }
            string customerResponse = Console.ReadLine();
            Console.WriteLine($"Are you sure you want{customerResponse}");
        }

        public List<FoodItem> GetMenuItems()
        {
            return new List<FoodItem>(foodItems);
        }
    }

}
