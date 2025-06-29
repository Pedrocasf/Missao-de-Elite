using UnityEngine;
using UnityEngine.Events;

public class DoAfterSeconds : MonoBehaviour
{
    [SerializeField] private bool repeatable;
    [SerializeField] private float timeInSeconds;
    [SerializeField] private UnityEvent onTriggered;

    private float nextTriggerTime;
    private bool hasTriggered;

    private void Start()
    {
        UpdateNextTime();
    }

    private void Update()
    {
        if(!hasTriggered && Time.time >= nextTriggerTime)
        {
            onTriggered?.Invoke();
            if (repeatable)
            {
                UpdateNextTime();
            }
            else
            {
                hasTriggered = true;
            }
        }
    }

    private void UpdateNextTime()
    {
        nextTriggerTime = Time.time + timeInSeconds;
    }

    public void ResetTimer()
    {
        UpdateNextTime();
    }
}
