using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryLab;

public static class InventoryItemFactory
{
    public static InventoryItem? Create(ProductType productType, String brand, String title, int quantityOnHand, float price, List<String> miscAttributes)
    {
        return productType switch
        {
            ProductType.Laptop => new Laptop(brand, title, quantityOnHand, price, productType, miscAttributes),
            ProductType.Smartphone => new Smartphone(brand, title, quantityOnHand, price, productType, miscAttributes),
            ProductType.RoboticVacuum => new RoboticVacuum(brand, title, quantityOnHand, price, productType, miscAttributes),
            ProductType.Camera => new Camera(brand, title, quantityOnHand, price, productType, miscAttributes),
            ProductType.AirFryer => new AirFryer(brand, title, quantityOnHand, price, productType, miscAttributes),
            _ => null
        };
    }
}
