using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    //MainScene�� �ε��Ŵ
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
