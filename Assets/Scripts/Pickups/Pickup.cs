using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    [SerializeField] private PickupData data;
    [SerializeField] private UnityEvent<PlayerController> onPickup;
    [SerializeField] private AudioSource audioSource;

    private void OnValidate()
    {
        if (data == null) return;
        name = $"Pickup [{data.PickupName}]";
    }

    public void Pick(PlayerController player)
    {
        onPickup?.Invoke(player);
        if (audioSource != null)
        {
            audioSource.gameObject.SetActive(true);
            audioSource.transform.SetParent(null);
        }
        if (data != null)
        {
            data.Trigger(player);
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlayerController player))
        {
            Pick(player);
        }
    }
}
