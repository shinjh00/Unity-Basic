using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTimeCoroutine : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float jumpCoolTime;

    public bool isJumpable;

    private void Update()
    {
        if (isJumpable && Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            StartCoroutine(JumpCoolTimeRoutine());
        }
    }

    IEnumerator JumpCoolTimeRoutine()
    {
        // 점프했으면 false 만들고 쿨타임 기다렸다가 끝나면 다시 true로 만들어주기
        isJumpable = false;
        //Debug.Log("점프 불가능");
        yield return new WaitForSeconds(jumpCoolTime);
        //Debug.Log("점프 가능");
        isJumpable = true;
    }
}
