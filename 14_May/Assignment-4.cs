using System;

abstract class FoodOrder
{
    public abstract void PlaceOrder(string item);
    public void OrderInfo()
    {
        Console.WriteLine("Placing food order");
    }
}
class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    
    {
        Console.WriteLine("Order placed for" + item + "at Fast Food Outlet");

    }
}
class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine("order placed for" + item + "at fine dining restaurant");

    }
}

class OrderProgram
{
    static void Main()
    {
        FoodOrder fastfood = new FastFoodOrder();
        FoodOrder fineDining = new FineDiningOrder();

        fastfood.OrderInfo();
        fastfood.PlaceOrder("Burger");

        fineDining.OrderInfo();
        fineDining.PlaceOrder("Pasta");
    }
}
