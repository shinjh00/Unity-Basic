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
            // ForceMode.Force : ���׽� �̴� ��
            // ForceMode.Force : �� �� �� ġ�� ��

            jumpCoolTime = 0f;
        }
    }
}
