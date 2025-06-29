using UnityEngine;

public class LookToPlayer : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = FindFirstObjectByType<PlayerController>().transform;
    }

    private void Update()
    {
        Vector3 direction = (player.position-transform.position).normalized;
        direction.y = 0;
        transform.right = direction;
    }
}
