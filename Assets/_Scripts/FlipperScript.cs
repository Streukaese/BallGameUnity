using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    public string inputName;
    bool pseudoPressed;

    public HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        // Startet Corroutine - Zufälliges Bewegen des Flipper objektes
        StartCoroutine(RandomFlipperMovement());
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        
        //if(Input.GetAxis(inputName) == 1)
        if(pseudoPressed)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
    }

    IEnumerator RandomFlipperMovement()
    {
        while(true)
        {
            // Wartet zwischen 1 und 3 Sekunden
            yield return new WaitForSeconds(Random.Range(1f, 3f));

            SimulateKeyPress();
            
            // Wartet um Flipper gedrückt zu halten
            yield return new WaitForSeconds(0.1f);

            SimulateKeyRelease();
        }
    }
    // Simuliert Tastendruck
    void SimulateKeyPress()
    {
        //Input.GetKeyDown(inputName);
        //transform.Rotate(Vector3.up * 45f);
        pseudoPressed = true;
    }
    // Simuliert Taste loslassen
    void SimulateKeyRelease()
    {
        //Input.GetKeyUp(inputName);
        //transform.Rotate(Vector3.up * 0f);
        pseudoPressed = false;
    }
}
