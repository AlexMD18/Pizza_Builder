/*
Alex Drogo
09/15/2020
CIS 4296
Prof.Pascucci
Description: This class handles all the calculations and assigns the prices for all menu items
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS3342_Projects
{
    public class Calculations
    {
        decimal deliveryCost = 0m;
        decimal sizeCost = 0m;
        decimal crustCost = 0m;
        decimal familyMealCost = 0m;
        decimal subTotal = 0m;

        //calculate the cost of delivery
        public decimal calcDeliveryPrice(string delivery)
        {
            if(delivery == "Delivery +($5.00)")
            {
                deliveryCost = 5.00m;
                return deliveryCost;
            }
            else
            {
                return deliveryCost;
            }
        }

        //calculate the cost of the pizza by size
        public decimal calcSizePrice(string size)
        {

            if(size == "Small ($8.99)")
            {
                sizeCost = 8.99m;
                return sizeCost;
            }
            else if(size == "Medium ($10.99)")
            {
                return 10.99m;
            }
            else if(size == "Large ($12.99)")
            {
                return 12.99m;
            }
            else if(size == "Extra Large ($15.99)")
            {
                return 15.99m;
            }
            else
            {
                return sizeCost;
            }
        }

        //calulate the cost of the pizza crust
        public decimal calcCrustType(string crust)
        {
            if(crust == "Stuffed Crust +($1.99)")
            {
                crustCost = 1.99m;
                return crustCost;
            }
            else if(crust == "Deep Dish +($2.99)")
            {
                crustCost = 2.99m;
                return crustCost;
            }
            else if(crust == "Cheesy Garlic Butter +($0.99)")
            {
                crustCost = 0.99m;
                return crustCost;
            }
            else
            {
                return 0.00m;
            }
        }

        //calulate the cost for the premium toppings. This method puts the items into an array and then counts the number of entries, then adds the
        //price per item.
        public decimal calcPremToppings(string premToppings)
            {
            int countToppings = 0;
            decimal premToppingCost = 0.00m;
            string[] split = premToppings.Split(',');
            countToppings = Convert.ToInt32(split.Count());
            premToppingCost = countToppings * 0.50m;
            return premToppingCost;
        }

        //calculate the cost when the user selects the family plan
        public decimal calcFamCost(string familyMeal)
        {
            if(familyMeal == "Yes +($4.99)")
            {
                familyMealCost = 4.99m;
                return familyMealCost;
            }
            else
            {
                return 0.00m;
            }
        }

    }
}