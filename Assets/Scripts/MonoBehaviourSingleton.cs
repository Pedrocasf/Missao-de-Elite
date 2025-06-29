using UnityEngine;

public class MonoBehaviourSingleton<T>: MonoBehaviour where T:MonoBehaviourSingleton<T>
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = (T)this;
        }
    }
}