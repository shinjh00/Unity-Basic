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
        // 고정 프레임 설정으로 테스트
        // 1초에 1프레임 1Update 수행되기 때문에 컴퓨터 성능(프레임)에 따라 속도, 이동거리가 달라질 수 있음
        // 이를 방지하기 위해 사용하는 것이 단위시간(DeltaTime)
    }

    private void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            //pos.x -= moveSpeed;  // 이렇게 하면 프레임에 따라 출력이 달라짐
            pos.x -= moveSpeed * Time.deltaTime;  // 이렇게 해야 컴퓨터 성능과 무관하게 같은 출력을 냄
        }
        if (Input.GetKey(KeyCode.D))
        {
            //pos.x += moveSpeed;
            pos.x += moveSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
