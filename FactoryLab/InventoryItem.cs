/*
* Name: Logan Brooks
* South Hills Username: lbrooks81
*/

using System;
using System.Collections.Generic;

namespace FactoryLab;

public abstract class InventoryItem
{
    //TODO: The other common properties go here!
    public String? Title { get; }
    public String? Brand { get; }
    public int Quantity { get; }
    public ProductType ProductType { get; }

    public float Price { get; } //Can only be assigned to in a constructor in this class

    public InventoryItem(String brand, String title, int quantityOnHand, float price, ProductType productType)
    {
        Brand = brand;
        Title = title;
        Quantity = quantityOnHand;
        Price = price;
        ProductType = productType;
    }
    public virtual void DisplayItem()
    {
        Console.WriteLine($"Title: {Title}\n Brand: {Brand}\n QOH: {Quantity}\n Product Type: {ProductType}\n Price: {Price.ToString("C2")}");
    }
}
