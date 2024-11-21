using UnityEngine;

public class BucketManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is a ball
        if (other.CompareTag("Ball"))
        {
            // Notify the GameManager that a ball was caught
            FindObjectOfType<GameManager>().BallCaught();

            // Destroy the ball
            Destroy(other.gameObject);
        }
    }
}
