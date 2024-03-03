using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTime : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float jumpCoolTime;

    private void Update()
    {
        jumpCoolTime += Time.deltaTime;

        if (jumpCoolTime >= 2f && Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            // ForceMode.Force : 지그시 미는 힘
            // ForceMode.Force : 한 번 툭 치는 힘

            jumpCoolTime = 0f;
        }
    }
}
