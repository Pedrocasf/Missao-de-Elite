using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage;

    private Alliance alliance;
    private Rigidbody rb;
    private float speed;

    public void Update()
    {
        rb.linearVelocity = transform.right * speed;
    }

    public void Initialize(Vector3 direction,float speed, Alliance isAllied)
    {
        this.speed = speed;
        rb = GetComponent<Rigidbody>();
        transform.right = direction;
        rb.linearVelocity = direction * speed;
        this.alliance = isAllied;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageable damageble) && !damageble.IsAllied(alliance))
        {
            damageble.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
