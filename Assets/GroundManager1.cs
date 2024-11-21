using UnityEngine;

public class GroundManager1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is a ball
        if (other.CompareTag("Ball"))
        {
            // Notify GameManager that the ball was missed
            FindObjectOfType<GameManager1>().BallMissed();

            // Destroy the ball
            Destroy(other.gameObject);
        }
    }
}
