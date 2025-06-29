using UnityEngine;
public class Weapon : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Alliance alliance;
    [SerializeField] private float projectileSpeed;

    [Header("Reference")]
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform projectileOrign;
    [SerializeField] private AudioSource source;

    [SerializeField] private float coolDownTime;
    private float coolDownUntilNextPress;
    public void Shoot()
    {
        if (coolDownUntilNextPress < Time.time)
        {
            Projectile projectile = Instantiate(projectilePrefab, projectileOrign.position, Quaternion.identity);
            projectile.Initialize(transform.forward, projectileSpeed, alliance);
            /*
            if (source != null)
            {
                source.Play();
            }
            */
            coolDownUntilNextPress = Time.time + coolDownTime;
        }
    }
}
