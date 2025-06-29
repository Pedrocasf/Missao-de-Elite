using UnityEngine;
using UnityEngine.Events;

public class Enemy: DamageableEntity
{
    [SerializeField] private int score;
    [SerializeField] private UnityEvent onDie;

    public UnityEvent OnDie => onDie;

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }

    public override void Die()
    {
        if (IsDead) return;
        base.Die();
        LevelManager.Instance.AddScore(score);
        onDie?.Invoke();
    }
}
