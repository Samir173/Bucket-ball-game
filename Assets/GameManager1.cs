using UnityEngine;
using TMPro; // Import TextMeshPro namespace
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;     // UI element for score
    public TextMeshProUGUI missedText;    // UI element for missed count
    public TextMeshProUGUI timeText;      // UI element for time remaining

    public int score = 0;                 // Current score
    public int missed = 0;                // Balls missed
    public float timeRemaining = 30f;     // Time for the level

    public int maxMissed = 10;            // Max missed before game over

    void Update()
    {
        // Reduce time
        timeRemaining -= Time.deltaTime;

        // Update time in the UI
        timeText.text = $"{Mathf.Ceil(timeRemaining)}";

        // Check for game over
        if (timeRemaining <= 0 || missed >= maxMissed)
        {
            GameOver();
        }
        if (timeRemaining >= 0 && score >= 10)
        {
            Passed();
        }
    }

    public void BallCaught()
    {
        // Increment score
        score++;
        scoreText.text = $"{score}";
    }

    public void BallMissed()
    {
        // Increment missed count
        missed++;
        missedText.text = $"{missed}";
    }

    void GameOver()
    {
        SceneManager.LoadScene("EndScreen");
    }
    void Passed()
    {
        SceneManager.LoadScene("Passed!");
    }
}
