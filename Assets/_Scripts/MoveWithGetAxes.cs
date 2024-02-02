using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithGetAxes : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    void Start()
    {
        
    }
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        Vector3 dir = (new Vector3(xInput,-1f, zInput)).normalized;

        // Nutzt Rigibody für Fortbewegung
        rb.AddForce(dir * speed);
    }
}
