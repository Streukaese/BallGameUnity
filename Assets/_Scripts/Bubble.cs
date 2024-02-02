using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Bubble b = collision.gameObject.GetComponent<Bubble>();
        if(b != null )
        {
            Destroy(b.gameObject);
        }
    }
    public static event Action<Bubble> Collided;
    public float speed = 10f;
    Vector3 dir;
    // statische Variable
    static int counter;
    private void OnTriggerEnter(Collider other)
    {
        Bubble b = other.gameObject.GetComponent<Bubble>();
        if(b != null)
        {
            Collided?.Invoke(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    public void Init(Vector3 dir)
    {
        this.dir = dir;
        counter++;
    }
}
