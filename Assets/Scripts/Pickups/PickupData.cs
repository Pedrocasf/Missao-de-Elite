using UnityEngine;

public abstract class PickupData : ScriptableObject
{
    [SerializeField] private string pickupName;

    public string PickupName => pickupName;

    public abstract void Trigger(PlayerController player);
}
