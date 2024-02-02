using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTestGp : MonoBehaviour
{
    public float speed = 10f;
    CharacterController controller;
    Rigidbody rb;
    bool hasController = true;
    Vector3 curDir = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (hasController)
        {
            float xInput = Input.GetAxis("Horizontal");
            float zInput = Input.GetAxis("Vertical");
            Vector3 dir = (new Vector3(xInput, -1f, zInput)).normalized;

            curDir = dir;
            controller.Move(dir * Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hole" && hasController)
        {
            hasController = false;

            // Deaktiviere den CharacterController
            controller.enabled = false;

            // Aktiviere den Rigidbody und setze die Geschwindigkeit
            rb.isKinematic = false;
            rb.velocity = curDir * speed;
        }
    }
}
