/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using System;
using System.Collections.Generic;

namespace FactoryLab;

public abstract class InventoryItem
{
    //TODO: The other common properties go here!
    public float Price { get; }//Can only be assigned to in a constructor in this class

    public virtual void DisplayItem()
    {
        //TODO: Implement the DisplayItem method
        throw new NotImplementedException();
    }
}
