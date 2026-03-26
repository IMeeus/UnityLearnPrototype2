using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float movementSpeed = 10.0f;
    public float horizontalBoundary = 10.0f;
    public InputActionReference moveReference;

    void Update()
    {
        horizontalInput = moveReference.action.ReadValue<Vector2>().x;

        if (horizontalInput < 0 && transform.position.x == -horizontalBoundary)
        {
            return;
        }

        if (horizontalInput > 0 && transform.position.x == horizontalBoundary)
        {
            return;
        }

        if (transform.position.x < -horizontalBoundary)
        {
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, transform.position.z);
            return;
        }
        else if (transform.position.x > horizontalBoundary)
        {
            transform.position = new Vector3(horizontalBoundary, transform.position.y, transform.position.z);
            return;
        }

        transform.Translate(movementSpeed * horizontalInput * Time.deltaTime * Vector3.right);
    }
}
