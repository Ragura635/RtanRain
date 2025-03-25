using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    //MainScene¿ª ∑ŒµÂΩ√≈¥
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
