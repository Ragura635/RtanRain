using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�̱���*
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
        //�ð��� 0���� ū��� �ð��� �带������ �ð� ����
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        //�ƴѰ�� �ð��� 0���� ���� �� Ÿ�ӽ�����*�� 0���� ����
        else
        {
            totalTime = 0;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        //����� �ð��� ĵ������ �ݿ�(�Ҽ��� 2�ڸ�����)
        timeTxt.text = totalTime.ToString("N2");
    }

    //����� ����
    void MakeRain()
    {
        Instantiate(rain);
    }

    //���� ����
    public void AddScore(int score)
    {
        totalScore += score;
        //����� ������ ĵ������ �ݿ�
        totalScoreTxt.text = totalScore.ToString();
    }
}
