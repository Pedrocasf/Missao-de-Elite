using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;

    private void Update()
    {
        transform.eulerAngles += direction * speed;
    }
}