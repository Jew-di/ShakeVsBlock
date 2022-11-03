using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private float _speed;

    public Vector3 Force; // задаЄм скорость и напрвление движени€

    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); //берЄм компонент риджибади, на весь периуд действи€ кода
    }


    private void FixedUpdate()
    {
        _speed = Speed * Time.deltaTime;
        _rigidbody.AddForce(Force * Speed, ForceMode.Acceleration);
        // задаЄм тип движени€: Force - придаЄм посто€нную силу, с учЄтом массы. Acceleration - придаЄм посто€нную силу, без учЄта массы.
        // Impulse - добавл€ем мгновенный импульс силы с учЄтом массы. VelocityChange - добавл€ем мгновенный импульс(изменение скорости) игнориру€ массу.
    }
}
