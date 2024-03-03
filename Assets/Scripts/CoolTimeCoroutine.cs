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
        // ���������� false ����� ��Ÿ�� ��ٷȴٰ� ������ �ٽ� true�� ������ֱ�
        isJumpable = false;
        //Debug.Log("���� �Ұ���");
        yield return new WaitForSeconds(jumpCoolTime);
        //Debug.Log("���� ����");
        isJumpable = true;
    }
}
