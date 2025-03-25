using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;
    SpriteRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpriteRenderer ���۳�Ʈ ��������
        renderer = GetComponent<SpriteRenderer>();
        //PC�� �������̰� �����Ƿ� �������� ����
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //���� ������ ���� ��ȯ
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

        //������ ������ �ڵ� �̵�
        transform.position += Vector3.right * direction;
    }
}
