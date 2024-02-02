using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShooterGeneratorCollider : MonoBehaviour
{
    public GameObject[] bubblePrefabs;
    public float xOffset;
    GameObject[,] bubbles = new GameObject[8, 4];
    // Start is called before the first frame update
    void Start()
    {
        // Verweist auf die "OnCollided" funktion
        Bubble.Collided += OnCollided;
        for(int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 8; i++)
            {
                // Initialisierung und Erstellung der Bubbles
                float stagger = j % 2 == 0 ? 0.5f : 0f;
                int rndIdx = Random.Range(0, bubblePrefabs.Length);
                GameObject bubble = Instantiate(bubblePrefabs[rndIdx]);
                bubble.transform.position = new Vector3(i + xOffset + stagger, j - j * 0.14f, 0);
                bubbles[i, j] = bubble;

                //bubble.GetComponent<Bubble>().Collided += OnCollided;
            }
        }

        //GameObject b = bubbles[0, 0];
        //bubbles[0, 0] = null;
        //Destroy(b);
        // Wählt Array oben Rechts aus ->>   bubbles[7, 3].transform.position += Vector3.forward;
    }
    public void OnCollided(Bubble b)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
