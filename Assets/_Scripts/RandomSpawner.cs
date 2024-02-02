using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Starten Sie die Coroutine "SpawnObjects" und übergeben Sie den Start-Timer
        StartCoroutine(SpawnObjects(Random.Range(1.0f, 3.0f)));
    }

    IEnumerator SpawnObjects(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            // Hier wird das Objekt gespawnt
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);

            // Aktualisieren Sie den Timer für den nächsten Spawn
            waitTime = Random.Range(1.0f, 3.0f);
        }
    }
    //void Start()
    //{
    //    Invoke("Spawn", Random.Range(1.0f, 3.0f));
    //}

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        // Spawnt das Objekt
        //Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        //Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);

        // Startet erneut die Methode "Spawn" zufällig nach 1,0 - 3,0 Sek.
        //Invoke("Spawn", Random.Range(1.0f, 3.0f));
        //}
    }
}
