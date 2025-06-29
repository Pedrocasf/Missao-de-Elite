using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviourSingleton<LevelManager>
{
    [SerializeField] private int currentScore;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void AddScore(int value)
    {
        currentScore += value;
        scoreText.text = $"Score: {currentScore}";
    }

}
