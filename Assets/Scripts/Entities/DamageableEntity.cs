using UnityEngine;
public class DamageableEntity: MonoBehaviour, IDamageable
{
    [SerializeField] protected RangedFloat life;
    [SerializeField] private Alliance alliance;
    [SerializeField] private MaterialFlashHandler materialFlash;

    public bool IsDead { get; private set; }

    public bool IsAllied(Alliance alliance)
    {
        return this.alliance == alliance; 
    }

    public virtual void TakeDamage(int damage)
    {
        if(materialFlash != null)
        {
            materialFlash.Flash(0.15f);
        }
        life.CurrentValue -= damage;
        if (life.IsMinValue())
        {
            Die();
        }
    }

    public virtual void Die()
    {
        IsDead = true;
        Destroy(gameObject);
    }
}
