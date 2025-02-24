using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class MenuHelper
    {

        /// <summary>
        ///  the menu contains an abstract consolemenu class, that extends menuItem and manages the list of menu items
        ///  makes the display menu work, and handle the users selcetion to navigate through the different options on the menu
        ///  the create menu method is abstract and defines how the menu is created while select, handles the user interactions with the choices
        /// </summary>
        internal abstract class ConsoleMenu : MenuItem
        {
            protected List<MenuItem> _menuItems = new List<MenuItem>();

            public bool IsActive { get; set; }

            public abstract void CreateMenu();

            public override void Select()
            {
                IsActive = true;
                do
                {
                    CreateMenu();
                    string output = $"{MenuText()}{Environment.NewLine}";
                    int selection = ConsoleUI.GetIntegerInRange(1, _menuItems.Count);
                    _menuItems[selection - 1].Select();
                } while (IsActive);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(MenuText());
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {_menuItems[i].MenuText()}");
                }
                return sb.ToString();
            }
        }
    }


}

