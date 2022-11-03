using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private float _speed;

    public Vector3 Force; // ����� �������� � ���������� ��������

    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); //���� ��������� ���������, �� ���� ������ �������� ����
    }


    private void FixedUpdate()
    {
        _speed = Speed * Time.deltaTime;
        _rigidbody.AddForce(Force * Speed, ForceMode.Acceleration);
        // ����� ��� ��������: Force - ������ ���������� ����, � ������ �����. Acceleration - ������ ���������� ����, ��� ����� �����.
        // Impulse - ��������� ���������� ������� ���� � ������ �����. VelocityChange - ��������� ���������� �������(��������� ��������) ��������� �����.
    }
}
