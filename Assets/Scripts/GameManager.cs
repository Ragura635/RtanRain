using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤*
    public static GameManager Instance;
    public GameObject rain;
    public GameObject endPanel;

    public Text totalScoreTxt;
    int totalScore = 0;
    public Text timeTxt;
    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("MakeRain", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //시간이 0보다 큰경우 시간이 흐를때마다 시간 감소
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        //아닌경우 시간을 0으로 고정 후 타임스케일*을 0으로 변경
        else
        {
            totalTime = 0;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        //변경된 시간을 캔버스에 반영(소숫점 2자리까지)
        timeTxt.text = totalTime.ToString("N2");
    }

    //빗방울 생성
    void MakeRain()
    {
        Instantiate(rain);
    }

    //점수 변경
    public void AddScore(int score)
    {
        totalScore += score;
        //변경된 점수를 캔버스에 반영
        totalScoreTxt.text = totalScore.ToString();
    }
}
