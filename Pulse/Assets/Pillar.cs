using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public float spawnDelay;
    public GameObject pillar;
    Queue<GameObject> activePillars = new Queue<GameObject>();

    // Use this for initialization
    void Start() {
        InvokeRepeating("Spawn", 2, spawnDelay);
    }


    void Spawn() {
        GameObject obj = (GameObject)Instantiate(pillar, new Vector3(Random.Range(-20, 20), Random.Range(-15, 15), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
    }
}
