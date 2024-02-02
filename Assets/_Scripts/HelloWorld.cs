using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Debug.Log("Hello World");
        Debug.Log("My name is " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown == Aktiv taste Drücken
        // GetKey == Taste Gibt immer true zurück(gedrückt halten)
        
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * speed * Time.deltaTime ;         // += new Vector3(1f, 2f, 3f); (sprung für die einzelnen pixel x,y,z)
                                                // Time.deltaTime = Gibt an wie lange gebraucht wurd zum Rendern + Macht Framrate Unabhängig
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
