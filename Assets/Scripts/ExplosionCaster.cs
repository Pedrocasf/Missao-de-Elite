using UnityEngine;

public class ExplosionCaster : MonoBehaviour
{
    [Min(0.0f)]
    [SerializeField] private float radius;
    [SerializeField] private int damage;
    [SerializeField] private Alliance alliance;
    [SerializeField] private ParticleSystem particles;

    public void Cast()
    {
        if (particles != null)
        {
            particles.transform.SetParent(null);
            particles.gameObject.SetActive(true);
            particles.Play();
        }
        ApplyDamage();
    }

    private void ApplyDamage()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hits)
        {
            if (hit.transform.TryGetComponent(out IDamageable damageable) && !damageable.IsAllied(alliance))
            {
                damageable.TakeDamage(damage);
            }
        }
    }
}
