using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class RepeatableAction : MonoBehaviour
{
    [SerializeField] private int defaultRepeatAmount;
    [SerializeField] private float defaultDelay;
    [SerializeField] private UnityEvent onTrigger;
    [SerializeField] private UnityEvent onActionStart;
    [SerializeField] private UnityEvent onActionEnd;

    public void Trigger()
    {
        Trigger(defaultRepeatAmount, defaultDelay);
    }

   public void Trigger(int amount, float delay)
   {
       StartCoroutine(PlayDelayedEvent(amount, delay));
   }

   private IEnumerator PlayDelayedEvent(int amount, float delay)
   {
       onActionStart?.Invoke();
       for(int i =0; i<amount; i++)
       {
           onTrigger?.Invoke();
           yield return new WaitForSeconds(delay);
       }
       onActionEnd?.Invoke();
   }
}
