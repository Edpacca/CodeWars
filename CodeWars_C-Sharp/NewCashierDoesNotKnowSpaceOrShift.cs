using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class NewCashierDoesNotKnowSpaceOrShift
    {
        static List<string> orders = new List<string>
        {
            "Burger",
            "Fries",
            "Chicken",
            "Pizza",
            "Sandwich",
            "Onionrings",
            "Milkshake",
            "Coke"
        };

        public static string GetOrder(string input)
        {
            StringBuilder formattedOrder = new StringBuilder();

            string buffer = input;

            foreach (var item in orders)
            {
                string itemLowerCase = item.ToLower();

                while (buffer.Contains(itemLowerCase))
                {
                    formattedOrder.Append(item + " ");
                    buffer = buffer.Remove(buffer.IndexOf(itemLowerCase), itemLowerCase.Length);
                }
            }

            return formattedOrder.ToString().Trim();
        }
    }
}
