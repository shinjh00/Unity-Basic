using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Rigidbody rigid;
    public float moveSpeed;
    public float rotateSpeed;

    private Vector3 moveDir;

    //public Transform headTransform;
    //public Transform firePoint;
    //public GameObject bulletPrefab;
    //public Bullet bulletPrefab;
    //public float bulletForce;
    //public float maxSpeed;
    //private Vector3 headDir;
    //public CinemachineVirtualCamera normalCamera;
    //public CinemachineVirtualCamera zoomCamera;
    //public Animator animator;

    // ������ - �̺�Ʈ
    //public UnityEvent OnFiring;
    //public UnityEvent OnFired;

    private void Update()
    {
        Rotate();
        //Head();
    }

    private void FixedUpdate()
    {
        Move();
    }
    
    private void OnMove(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x;
        moveDir.z = inputDir.y;
        if (moveDir.z < 0)
        {
            moveDir.x *= -1;
        }
    }

    private void Move()
    {
        Vector3 forceDir = transform.forward * moveDir.z;
        //rigid.AddForce(forceDir * moveSpeed, ForceMode.Force);
        transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime);

        /*if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;
        }*/
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }


    /*private void OnFire(InputValue value)
    {
        Fire();
    }*/

    /*private void Fire()
    {
        OnFiring.Invoke();

        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce;

        //animator.SetTrigger("Fire");

        // �̱���
        Manager.Data.AddFireCount();    // ������ �Ŵ�������
        Manager.Game.GamePause();       // ���� �Ŵ�������

        OnFired.Invoke();
    }*/

    private void Head()
    {
    }

    /*
    private void OnHead()
    {
        Vector2 inputDir = InputValue.Get<Vector2>();
        headDir.x = inputDir.x;
        headDir.y = inputDir.y;
    }


    private void OnZoom(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Zoom on");
            zoomCamera.Priority = 50;
        }
        else
        {
            Debug.Log("Zoom off");
            zoomCamera.Priority = 1;
        }
    }*/
}