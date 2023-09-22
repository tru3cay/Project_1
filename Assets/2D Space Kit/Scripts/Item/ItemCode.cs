using System;
using System.Diagnostics;

public enum ItemCode
{
    NoItem = 0,
    ItemOne = 1,
    ItemTwo = 2,
    MissileOne = 3,
}

public class ItemCodeParser { 
    public static ItemCode FromString(string itemName)
    {
        try
        {
            return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
        }
        catch(ArgumentException e)
        {
            return ItemCode.NoItem;
        }
    }
}
