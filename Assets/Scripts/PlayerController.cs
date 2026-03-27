using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float horizontalBoundary = 10.0f;
    public GameObject projectilePrefab;

    public InputActionReference moveAction;
    public InputActionReference projectileAction;

    void Update()
    {
        UpdateMove();
        UpdateShoot();
    }

    private void UpdateMove()
    {
        var horizontalInput = moveAction.action.ReadValue<Vector2>().x;

        if (horizontalInput == 0) return;

        float newX = transform.position.x + horizontalInput * movementSpeed * Time.deltaTime;
        float clampedX = Mathf.Clamp(newX, -horizontalBoundary, horizontalBoundary);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }

    private void UpdateShoot()
    {
        if (projectileAction.action.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
