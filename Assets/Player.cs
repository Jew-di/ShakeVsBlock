using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 Force; // ����� �������� � ���������� ��������

    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); //���� ��������� ���������, �� ���� ������ �������� ����
    }


    private void FixedUpdate()
    {
        _rigidbody.AddForce(Force, ForceMode.Acceleration);
        // ����� ��� ��������: Force - ������ ���������� ����, � ������ �����. Acceleration - ������ ���������� ����, ��� ����� �����.
        // Impulse - ��������� ���������� ������� ���� � ������ �����. VelocityChange - ��������� ���������� �������(��������� ��������) ��������� �����.
    }
}
