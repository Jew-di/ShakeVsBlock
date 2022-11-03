using System.Collections;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float Speed;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h * Speed, rb.velocity.y, 0);
        rb.AddForce(movement);
    }
}