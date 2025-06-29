using UnityEngine;

[CreateAssetMenu(fileName ="Pickup_Heal_",menuName = "Pickups/Heal")]
public class HealPickup : PickupData
{
    [Min(0)]
    [SerializeField] private int healAmount;

    public override void Trigger(PlayerController player)
    {
        player.Heal(healAmount);
    }
}
