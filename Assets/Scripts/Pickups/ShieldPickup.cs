using UnityEngine;

[CreateAssetMenu(fileName = "Pickup_Shield_", menuName = "Pickups/Shield")]
public class ShieldPickup : PickupData
{
    [Min(0)]
    [SerializeField] private float shieldDuration;

    public override void Trigger(PlayerController player)
    {
        player.AddShield(shieldDuration);
    }
}