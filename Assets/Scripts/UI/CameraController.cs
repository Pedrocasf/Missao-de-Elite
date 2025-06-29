using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset;


    private void OnValidate()
    {
        if (player == null) return;
        Vector3 finalOffset = player.transform.position + offset;
        transform.position = finalOffset;
    }

    void LateUpdate()
    {
        if (player == null) return;
        transform.position = player.transform.position + offset;
    }
}
