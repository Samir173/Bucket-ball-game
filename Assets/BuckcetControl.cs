using UnityEngine;

public class BucketController : MonoBehaviour
{
    public float speed = 10f; // Movement speed
    private float screenLimitX; // Screen bounds for bucket movement

    void Start()
    {
        // Calculate the horizontal screen limits
        screenLimitX = Camera.main.orthographicSize * Camera.main.aspect;
    }

    void Update()
    {
        // Get horizontal input (A/D or Arrow Keys)
        float moveInput = Input.GetAxis("Horizontal");

        // Move the bucket horizontally
        transform.Translate(moveInput * speed * Time.deltaTime, 0, 0);

        // Clamp the bucket's position to stay within the screen bounds
        float clampedX = Mathf.Clamp(transform.position.x, -screenLimitX + 0.5f, screenLimitX - 2.5f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}

