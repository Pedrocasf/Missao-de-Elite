using UnityEngine;

public class PauseWhileEnabled : MonoBehaviour
{
    private float lastTimeScale;

    private void OnEnable()
    {
        if(Time.timeScale != 0)
        {
            lastTimeScale = Time.timeScale;
        }
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = lastTimeScale;
    }
}
