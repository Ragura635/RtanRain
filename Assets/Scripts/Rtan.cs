using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;
    SpriteRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpriteRenderer 컴퍼넌트 가져오기
        renderer = GetComponent<SpriteRenderer>();
        //PC별 성능차이가 있으므로 프레임을 고정
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //조건 만족시 방향 전환
        if (Input.GetMouseButtonDown(0))
        {
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }
        if(transform.position.x > 2.6)
        {
            renderer.flipX = true;
            direction = -0.05f;
        }
        if(transform.position.x < -2.6)
        {
            renderer.flipX = false;
            direction = 0.05f;
        }

        //지정된 방향대로 자동 이동
        transform.position += Vector3.right * direction;
    }
}
