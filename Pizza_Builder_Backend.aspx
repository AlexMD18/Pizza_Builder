<!--
Alex Drogo
09/15/2020
CIS 4296
Prof.Pascucci
Description: This page creates the table that where the inputted values from the menu and all calculations will be for the customer receipt.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pizza_Builder_Backend.aspx.cs" Inherits="CIS3342_Projects.Pizza_Builder_Backend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="RecieptCSS.css" rel="stylesheet" />
<link rel="shortcut icon" type="image/png" href="Images/pizza_icon.png" />
    <title>Weirdough's Pizza Reciept</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Weirdough's Pizza</h2>
        <h3>Here is your order receipt</h3>
        <!--Table that holds the inputted values from menu as well as final calculations. All values inserted into lables-->
        <table id="receipt" style="text-align: center">
            <tr>
                <td class="lblName">Name:
                    <asp:Label ID="customerNameLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblAddress">Address:
                    <asp:Label ID="customerAddressLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblPhoneNum">Phone Number:
                    <asp:Label ID="customerPhoneNumLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblTkoOption">Takeout Option:
                    <asp:Label ID="customerTkoOptionRDIO" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblPizzaSize">Pizza Size:
                    <asp:Label ID="pizzaSizeRDIO" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblCrustType">Crust:
                    <asp:Label ID="crustTypeRDIO" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblSauceType">Sauce:
                    <asp:Label ID="sauceTypeRDIO" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblPizzaToppings">Toppings:
                    <asp:Label ID="pizzaToppingsCHK" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblPremPizzaToppings">Premium Toppings:
                    <asp:Label ID="premPizzaToppingsCHK" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblFamilyMeal">Family Meal:
                    <asp:Label ID="familyMealRDIO" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblDrinkType">Drink:
                    <asp:Label ID="drinkTypeDDL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblSideType">Side:
                    <asp:Label ID="sideTypeDDL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblTip">Tip:
                    <asp:Label ID="tipLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblSubtotal">Subtotal:
                    <asp:Label ID="subtotalLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblTax">Tax:
                    <asp:Label ID="taxLBL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="lblTotal"><strong>Total Cost: </strong>
                    <asp:Label ID="totalLBL" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
