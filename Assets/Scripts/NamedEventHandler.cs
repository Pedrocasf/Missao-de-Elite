using System.Collections.Generic;
using UnityEngine;

public class NamedEventHandler : MonoBehaviour
{
    [SerializeField] private List<NamedEvent> events;
    private Dictionary<string, NamedEvent> eventByName = new Dictionary<string, NamedEvent>();

    private void Awake()
    {
        foreach (NamedEvent nEvent in events)
        {
            eventByName.Add(nEvent.EventName, nEvent);
        }
    }

    public void TriggerEvent(string key)
    {
        if (eventByName.TryGetValue(key, out NamedEvent namedEvent))
        {
            namedEvent.OnTrigger?.Invoke();
        }
    }

    public void TriggerAll()
    {
        foreach (NamedEvent nEvent in events)
        {
            nEvent.OnTrigger?.Invoke();
        }
    }
}
