using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCheats : MonoBehaviour
{
    [SerializeField] private KeyCode startLevel1 = KeyCode.F2;
    [SerializeField] private KeyCode startLevel2 = KeyCode.F3;
    [SerializeField] private KeyCode startLevel3 = KeyCode.F4;
    [SerializeField] private KeyCode infinteLife = KeyCode.F5;

    private void Update()
    {
        if (Input.GetKeyDown(startLevel1))
        {
            SceneManager.LoadScene("Scene_Level1");
        }else if (Input.GetKeyDown(startLevel2))
        {
            SceneManager.LoadScene("Scene_Level2");
        }else if (Input.GetKeyDown(startLevel3))
        {
            SceneManager.LoadScene("Scene_Level3");
        }
        else if (Input.GetKeyDown(infinteLife))
        {
            PlayerController.isImmortal = !PlayerController.isImmortal;
        }
    }
}
