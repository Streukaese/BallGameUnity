using Crazyball;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void Start()
    {
        
    }
    // Ein Event == Wenn das Passiert/ausgef�hrt wird (Ball f�llt ins Loch/Ziel)
    void OnTriggerEnter(Collider other)
    {
        // Verkn�pfung des Spielobjektes mit der Ziel Bedingung // Auf die Benutzte Komponente Achten Controller == Controller || Rigibudy == GetAxis (Klasse "MoveGetAxes")
        MoveWithGetAxes component = other.gameObject.GetComponent<MoveWithGetAxes>();
        if (component != null)
        {
            // L�dt die neue Seite wenn "component" != null ist
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void Update()
    {
        
    }
}