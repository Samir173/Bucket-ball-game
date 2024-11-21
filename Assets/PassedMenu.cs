using UnityEngine;
using UnityEngine.SceneManagement;

public class PassedMenu : MonoBehaviour
{
    public void returngame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
