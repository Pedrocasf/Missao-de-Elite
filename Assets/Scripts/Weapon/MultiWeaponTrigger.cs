using System.Collections.Generic;
using UnityEngine;

public class MultiWeaponTrigger : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons;

    public void Trigger()
    {
        foreach (Weapon weapon in weapons)
        {
            weapon.Shoot();
        }
    }
}
