using UnityEngine.SceneManagement;

public class RetrySceneButton : ButtonBehaivour
{
    protected override void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
