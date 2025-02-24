using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes

    /// this class encapsulares the recipe for the burger including the name, a list of default garnishes, and its price. 
    /// the constructor initializes the properties, which then allows the bruger to be created based on the recipe.
   

{

    public class BurgerRecipe
{
    public string Name { get; private set; }
    public List<Garnish> Garnishes { get; private set; }
    public decimal BasePrice { get; private set; }

    public BurgerRecipe(string name, List<Garnish> garnishes, decimal basePrice)
    {
        Name = name;
        Garnishes = garnishes;
        BasePrice = basePrice;
    }
}

}
