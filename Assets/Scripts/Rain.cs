using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;
    SpriteRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpriteRenderer 컴퍼넌트 가져오기
        renderer = GetComponent<SpriteRenderer>();

        //생성된 오브젝트가 이동될 위치 지정
        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3, 5);
        transform.position = new Vector3(x, y, 0);

        //랜덤하게 오브젝트의 타입 지정
        int type = Random.Range(1, 5);
        //소형 빗방울
        if (type == 1)
        {
            size = 0.8f;
            score = 1;
            renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
        }
        //중형 빗방울
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            renderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
        }
        //대형 빗방울
        else if (type == 3)
        {
            size = 1.2f;
            score = 3;
            renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
        }
        //감점 빗방울
        else if (type == 4)
        {
            size = 0.8f;
            score = -5;
            renderer.color = new Color(1f, 100 / 255f, 1f, 1f);
        }
        //지정한 사이즈로 오브젝트 스케일 변경
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ground와 충돌시 비 오브젝트 파괴
        if (collision.gameObject.CompareTag("Ground")) 
        {
            Destroy(this.gameObject);
        }
        //player와 충돌시 점수증가, 비 오브젝트 파괴
        else if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
