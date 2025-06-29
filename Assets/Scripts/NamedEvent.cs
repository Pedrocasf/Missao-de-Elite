using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class NamedEvent
{
    [SerializeField] private string eventName;
    [SerializeField] private UnityEvent onTrigger;

    public string EventName => eventName;
    public UnityEvent OnTrigger => onTrigger;
}
