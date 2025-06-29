using System.Collections;
using UnityEngine;

public class PlayerController : DamageableEntity
{
    [SerializeField] private float speed;
    [SerializeField] private Weapon weapon;
    [SerializeField] private LifeBar lifeBar;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject shield;

    private Rigidbody rb;
    private Camera mainCamera;
    private bool isShielded;

    public static bool isImmortal;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
        }
        if (Time.timeScale == 0) return;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetMouseButton(0))
        {
            weapon.Shoot();
        }
        horizontalInput *= Time.deltaTime * speed;
        verticalInput *= Time.deltaTime * speed;
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        rb.linearVelocity = -movement * speed;
        HandleMouseInput();
    }
    private void HandleMouseInput()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.transform.position.y;
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        Vector3 direction = (mouseWorldPosition - transform.position).normalized;
        direction.y = 0;
        transform.forward = direction;
    }

    public void AddShield(float durationSeconds)
    {
        StartCoroutine(ActivateShield(durationSeconds));
    }

    private IEnumerator ActivateShield(float durationSeconds)
    {
        isShielded = true;
        shield.SetActive(true);
        yield return new WaitForSeconds(durationSeconds);
        shield.SetActive(false);
        isShielded = false;
    }

    public override void TakeDamage(int damage)
    {
        if (isImmortal) return;
        if (isShielded) return;
        base.TakeDamage(damage);
        lifeBar.SetLifeValue(life);
    }

    public void Heal(int amount)
    {
        life.CurrentValue += amount;
        lifeBar.SetLifeValue(life);
    }

    public override void Die()
    {
        if (IsDead) return;
        gameOverMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
