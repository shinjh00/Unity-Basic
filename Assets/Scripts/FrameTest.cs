using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTest : MonoBehaviour
{
    [SerializeField] Transform trans;
    [SerializeField] float moveSpeed;

    private void Start()
    {
        Application.targetFrameRate = 60;
        //Application.targetFrameRate = 10;
        // ���� ������ �������� �׽�Ʈ
        // 1�ʿ� 1������ 1Update ����Ǳ� ������ ��ǻ�� ����(������)�� ���� �ӵ�, �̵��Ÿ��� �޶��� �� ����
        // �̸� �����ϱ� ���� ����ϴ� ���� �����ð�(DeltaTime)
    }

    private void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            //pos.x -= moveSpeed;  // �̷��� �ϸ� �����ӿ� ���� ����� �޶���
            pos.x -= moveSpeed * Time.deltaTime;  // �̷��� �ؾ� ��ǻ�� ���ɰ� �����ϰ� ���� ����� ��
        }
        if (Input.GetKey(KeyCode.D))
        {
            //pos.x += moveSpeed;
            pos.x += moveSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}