using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : ButtonBehaivour
{
    [SerializeField] private string sceneName;
    protected override void OnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
