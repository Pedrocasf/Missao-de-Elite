using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Image fillBarImage;
    public void SetLifeValue(RangedFloat life)
    {
        fillBarImage.fillAmount = life.Percentage;
    }
}
