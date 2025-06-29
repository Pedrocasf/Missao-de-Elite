using UnityEngine;

public class ExitButton : ButtonBehaivour
{
    protected override void OnClick()
    {
        Application.Quit();
    }
}