using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies;
    [SerializeField] private TwoStateObject[] doors;
    [SerializeField] private bool isInitialRoom;

    private const string playerTag = "Player";
    private int currentEnemyAmount;
    private bool isCompleted;

    private void Start()
    {
        foreach (Enemy enemy in enemies)
        {
            enemy.OnDie.AddListener(OnEnemyDie);
            if (isInitialRoom) continue;
            enemy.gameObject.SetActive(true);
        }
        currentEnemyAmount = enemies.Length;
        isCompleted = currentEnemyAmount == 0;
        if (isInitialRoom && isCompleted)
        {
            Complete();
        }
    }

    private void OnDestroy()
    {
        foreach (Enemy enemy in enemies)
        {
            enemy.OnDie.RemoveListener(OnEnemyDie);
        }
    }


    public void Initialize()
    {
        if (isCompleted) return;


        foreach (TwoStateObject door in doors)
        {
            door.Disable();
        }
        foreach (Enemy enemy in enemies)
        {
            enemy.gameObject.SetActive(true);
        }
    }

    private void OnEnemyDie()
    {
        if (isCompleted) return;

        currentEnemyAmount--;
        if(currentEnemyAmount <= 0)
        {
           Complete();
        }
    }

    private void Complete()
    {
        foreach (TwoStateObject door in doors)
        {
            door.Enable();
        }
        isCompleted = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Initialize();
        }
    }
}
