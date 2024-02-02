using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public float xOffset, yOffset, zOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(Player.transform.position);
    }
}
