using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;
    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}