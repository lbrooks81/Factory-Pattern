using System;
using System.Collections.Generic;

namespace FactoryLab;

public class Laptop : InventoryItem
{
    public String Resolution { get; set; }
    public String Storage { get; set; }
    public String RAMSize { get; set; }
    public String CPU { get; set; }
    public String ScreenSize { get; set; }

    public Laptop(String brand, String title, int quantityOnHand, 
        float price, ProductType productType, List<String> miscAttributes)
            : base(brand, title, quantityOnHand, price, productType)
    {
        Resolution = miscAttributes[0];
        ScreenSize = miscAttributes[1];
        Storage = miscAttributes[2];
        RAMSize = miscAttributes[3];
        CPU = miscAttributes[4];
    }
    public override void DisplayItem()
    {
        base.DisplayItem();
        Console.WriteLine($" Screen Size: {ScreenSize}");
        Console.Write(Environment.NewLine);
    }
}

public class Smartphone : InventoryItem
{
    public String Resolution { get; set; }
    public String Storage { get; set; }
    public String RAMSize { get; set; }
    public String CPU { get; set; }
    public String CameraResolution { get; set; }

    public Smartphone(String brand, String title, int quantityOnHand,
        float price, ProductType productType, List<String> miscAttributes)
        : base(brand, title, quantityOnHand, price, productType)
    {
        Resolution = miscAttributes[0];
        Storage = miscAttributes[1];
        RAMSize = miscAttributes[2];
        CPU = miscAttributes[3];
        CameraResolution = miscAttributes[4];
    }
    public override void DisplayItem()
    {
        base.DisplayItem();
        Console.WriteLine($" Camera Resolution: {CameraResolution}");
        Console.Write(Environment.NewLine);
    }
}

public class RoboticVacuum : InventoryItem
{
    public String CleaningPathWidth { get; set; }
    public bool Bagless { get; set; }
    public String Color { get; set; }
    public String Weight { get; set; }
    public RoboticVacuum(String brand, String title, int quantityOnHand,
        float price, ProductType productType, List<String> miscAttributes)
        : base(brand, title, quantityOnHand, price, productType)
    {
        CleaningPathWidth = miscAttributes[0];
        Bagless = miscAttributes[1] == "yes" ? true : false; ;
        Color = miscAttributes[2];
        Weight = miscAttributes[3];
    }
    public override void DisplayItem()
    {
        base.DisplayItem();
        Console.WriteLine($" Cleaning Path Width: {CleaningPathWidth}\n Bagless: {Bagless}\n Color: {Color}\n Weight: {Weight}");
        Console.Write(Environment.NewLine);
    }
}

public class Camera : InventoryItem
{
    public String ImageSensorType { get; set; }
    public String EffectivePixels { get; set; }
    public String VideoResolution { get; set; }
    public Camera(String brand, String title, int quantityOnHand,
        float price, ProductType productType, List<String> miscAttributes)
        : base(brand, title, quantityOnHand, price, productType)
    { 
        ImageSensorType = miscAttributes[0];
        EffectivePixels = miscAttributes[1];
        VideoResolution = miscAttributes[2];
    }
    public override void DisplayItem()
    {
        base.DisplayItem();
        Console.WriteLine($" Image Sensor Type: {ImageSensorType}\n Effective Pixels: {EffectivePixels}\n Video Resolution: {VideoResolution}");
        Console.Write(Environment.NewLine);
    }
}

public class AirFryer : InventoryItem
{
    public bool NonStick { get; set; }
    public String Color { get; set; }
    public String[] Functions { get; set; }

    public AirFryer(String brand, String title, int quantityOnHand,
        float price, ProductType productType, List<String> miscAttributes)
        : base(brand, title, quantityOnHand, price, productType)
    {
        NonStick = miscAttributes[0] == "yes" ? true : false;
        Color = miscAttributes[1];
        Functions = miscAttributes[2].Split('/');
    }
    public override void DisplayItem()
    {
        base.DisplayItem();
        Console.WriteLine($" NonStick Interior: {NonStick}\n Color: {Color}\n Functions: {String.Join(", ", Functions)}");
        Console.Write(Environment.NewLine);
    }
}
