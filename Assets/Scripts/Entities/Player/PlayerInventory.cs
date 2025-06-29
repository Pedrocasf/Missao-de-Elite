using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Dictionary<string, int> container = new Dictionary<string, int>();

    public void AddItem(string item, int amount = 1)  
    {
        if (!ContainsItem(item))
        {
            container[item] = amount;
        }else
        {
            container[item] += amount;
        }
    }

    public void RemoveItem(string item, int amount = 1)
    {
        if (!ContainsItem(item))
            return;

        container[item] -= amount;
        if (container[item] <= 0)
        {
            container.Remove(item);
        }
    }

    public bool ContainItemAmount(string item, int amount)
    {
        if(container.TryGetValue(item, out int value))
        {
            return value >= amount;
        }
        return false;
    }

    public bool ContainsItem(string item)
    {
        return container.ContainsKey(item);
    }
}
