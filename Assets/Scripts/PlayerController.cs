using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }
    float _yAngle = 0.0f;
    void Update()
    {
        _yAngle += Time.deltaTime * _speed * 100;

        // ���� ȸ����
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // +,- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * _speed * 100, 0.0f));

        // ���ϴ� �������� ȸ��
        // Quaternion: Vector3�� ����ϸ� gimbal lock ������ �߻��ϱ� ������ �̸� �����ϱ� ���� ���
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));

        if (Input.GetKey(KeyCode.W))
<<<<<<< HEAD
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.05f);

            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
            
        if (Input.GetKey(KeyCode.S))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.05f);

            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.back * Time.deltaTime * _speed;

        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.05f);

            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.left * Time.deltaTime * _speed;

        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.05f);

            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.right * Time.deltaTime * _speed;

        }

=======
            transform.position += new Vector3(0.0f, 0.0f, 1.0f);
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0.0f, 0.0f, 1.0f);
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(1.0f, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(1.0f, 0.0f, 0.0f);
>>>>>>> parent of 38f5f6c (Set Player)
    }
}
