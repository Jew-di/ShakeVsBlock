using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //������� �������
    {
        Debug.Log("Object has entered the trigger"); //�������� ��������� ��� ������ � ���� �������
        other.GetComponent<Rigidbody>().AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange); //��� ����� � ������ ������ ��������� �� ��� X
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is inside trigger"); //��������� ��������� ��� ���������� ������� � �������
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
        Debug.Log("Object has exited the trigger"); //��������� ��������� ��� ������ ������� �� �������
    }


}
