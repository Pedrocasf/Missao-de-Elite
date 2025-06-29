using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonBehaivour : MonoBehaviour
{
    protected Button targetButton;

    protected void Awake()
    {
        targetButton = GetComponent<Button>();
        targetButton.onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();
}
