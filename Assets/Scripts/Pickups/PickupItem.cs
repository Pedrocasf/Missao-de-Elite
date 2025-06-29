using UnityEngine;

[CreateAssetMenu(fileName = "ItemPickup_",menuName = "Pickups/Item")]
public class PickupItem : PickupData
{
    [SerializeField] private string itemName;
    [Min(1)] 
    [SerializeField] private int itemAmount = 1;

    public override void Trigger(PlayerController player)
    {
        if(player.TryGetComponent(out PlayerInventory inventory))
        {
            inventory.AddItem(itemName, itemAmount);
        }
    }
}
