/*
Alex Drogo
09/15/2020
CIS 4296
Prof. Pascucci
Description: This class is the backend for the reciept page. It takes the info that was inserted on the menu page and writes the reciept.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342_Projects
{
    public partial class Pizza_Builder_Backend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                decimal tipAmount = 0.00m;
                decimal tax = 0.00m;
                decimal subtotal = 0.00m;
                decimal total = 0.00m;

                //Requests data from form
                String customerName = Request["txtCustName"];
                String customerAddress = Request["txtCustAddress"];
                String customerPhone = Request["txtCustPhone"];
                String takeoutOption = Request["rdioTkoOption"];
                String pizzaSize = Request["rdioPizzaSize"];
                String crustType = Request["ddlCrustType"];
                String sauceType = Request["ddlSauceType"];
                String toppings = Request.Form["chkToppings"];
                String premToppings = Request.Form["chkPremToppings"];
                String familyMeal = Request["rdioFamilyMeal"];
                String drink = Request["ddlDrinkType"];
                String side = Request["ddlSideType"];
                String tip = Request["txtTip"];

                Calculations calc = new Calculations();

                //passes the data into the lables on the reciept
                customerNameLBL.Text = customerName;
                customerAddressLBL.Text = customerAddress;
                customerPhoneNumLBL.Text = customerPhone;
                customerTkoOptionRDIO.Text = takeoutOption;
                pizzaSizeRDIO.Text = pizzaSize;
                crustTypeRDIO.Text = crustType;
                sauceTypeRDIO.Text = sauceType;
                pizzaToppingsCHK.Text = toppings;
                premPizzaToppingsCHK.Text = premToppings;
                familyMealRDIO.Text = familyMeal;
                drinkTypeDDL.Text = drink;
                sideTypeDDL.Text = side;
                //if tip is left empty it is 0. Otherwise add it to the total.
                if(tip == "")
                {
                    tipLBL.Text = tipAmount.ToString();
                }
                else
                {
                    //calculate tax, subtotal and total
                    tipLBL.Text = tip;
                    tipAmount = Convert.ToDecimal(tip);
                    subtotal = (calc.calcDeliveryPrice(takeoutOption) + calc.calcSizePrice(pizzaSize) + calc.calcCrustType(crustType) + calc.calcFamCost(familyMeal) 
                        + calc.calcPremToppings(premToppings) + tipAmount);

                    //PA tax = 6%
                    tax = (calc.calcDeliveryPrice(takeoutOption) + calc.calcSizePrice(pizzaSize) + calc.calcCrustType(crustType) + calc.calcFamCost(familyMeal) + calc.calcPremToppings(premToppings) + tipAmount) * .06m;
                    total = subtotal + tax;
                }

                subtotalLBL.Text = subtotal.ToString("C");
                taxLBL.Text = tax.ToString("C");
                totalLBL.Text = total.ToString("C");

                /*Response.Write("<h2>Thank you for shopping at Weirdough's Pizza!</h2>");
                Response.Write("<h3>Here is your order receipt</h3>");
                Response.Write("<p><Strong>Name:</Strong> " + customerName + "<p>");
                Response.Write("<p><Strong>Address:</Strong> " + customerAddress + "<p>");
                Response.Write("<p><Strong>Phone Number:</Strong> " + customerPhone + "<p>");
                Response.Write("<p><Strong>Takeout Option:</Strong> " + takeoutOption + "<p>");
                Response.Write("<p><Strong>Pizza Size:</Strong> " + pizzaSize + "<p>");
                Response.Write("<p><Strong>Crust Type:</Strong> " + crustType + "<p>");
                Response.Write("<p><Strong>Sauce Type:</Strong> " + sauceType + "<p>");
                Response.Write("<p><Strong>Toppings:</Strong> " + toppings + "<p>");
                Response.Write("<p><Strong>Premium Toppings:</Strong> " + premToppings + "<p>");
                Response.Write("<p><Strong>Family Meal?</Strong> " + familyMeal + "<p>");
                Response.Write("<p><Strong>Drink:</Strong> " + drink + "<p>");
                Response.Write("<p><Strong>Side:</Strong> " + side + "<p>");*/
            }
        }
    }
}