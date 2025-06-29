using UnityEngine;

public class DieOnCollisionEnenmyBehaviour : MonoBehaviour
{
    [SerializeField] private DamageableEntity entity;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Player")) return;
        entity.Die();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        entity.Die();
    }
}