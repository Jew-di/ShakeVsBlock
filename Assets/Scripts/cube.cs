using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //функция тригера
    {
        Debug.Log("Object has entered the trigger"); //печатаем сообщение при заходе в зону тригера
        other.GetComponent<Rigidbody>().AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange); //при входе в тригер придаём ускорение по оси X
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is inside trigger"); //песчатаем сообщение при нахождении объекта в тригере
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
        Debug.Log("Object has exited the trigger"); //песчатаем сообщение при выходе объекта из тригера
    }


}
