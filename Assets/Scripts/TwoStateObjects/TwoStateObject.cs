using UnityEngine;

public class TwoStateObject : MonoBehaviour
{
    [SerializeField] private bool initialState;
    [SerializeField] private bool triggerStateOnStart;

    public bool CurrentState { get; private set; }

    private void Start()
    {
        if (triggerStateOnStart)
        {
            if (initialState)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }
    }

    public void Toggle()
    {
        if (CurrentState)
        {
            Disable();
        }
        else
        {
            Enable();
        }

    }
    
    public virtual void Enable()
    {
        CurrentState = true;
    }

    public virtual void Disable()
    {
        CurrentState = false;
    }
}
