using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 0;  // ����t��

    void Start()
    {
        // ����t�סB�����L����
        // transform.Rotate(0, 0, 50);
    }

    void Update()
    {
        // �Y�I���ƹ��N�n�]�w����t��
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }

        // ����t�סB�����L����
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.996f;
    }
}