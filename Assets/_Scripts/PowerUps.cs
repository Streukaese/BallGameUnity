using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PowerUps : MonoBehaviour
{
    public MoveWithGetAxes move;

    public float moveSpeed = 6.0f;
    public float normalMoveSpeed;
    public float jumpSpeed = 0f;
    public float normalJumpSpeed;
    public float friction = 6f;
    public float normalFriction;
    public float gravity = 20f;
    public float normalGravity;

    void Start()
    {
        normalMoveSpeed = move.speed;
        normalJumpSpeed = jumpSpeed;
    }
    //Controller
    void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "SpeedBoost":
                moveSpeed = 3000f;
                //GetComponent<Rigidbody>().AddForce(Vector3.forward * moveSpeed, ForceMode.Impulse);
                break;
            case "JumpPad":
                jumpSpeed = 15f;
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
                break;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "JumPad" || other.gameObject.tag == "SpeedBoost")
        {
            jumpSpeed = normalJumpSpeed;
            moveSpeed = normalMoveSpeed;
        }
    }
}
