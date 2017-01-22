using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public float spawnDelay;
    public GameObject pillar;
    public Transform wavePrefab;
    Queue<GameObject> activePillars = new Queue<GameObject>();

    // Use this for initialization
    void Start() {
        InvokeRepeating("Spawn", 2, spawnDelay);
    }

    // Update is called once per frame
    void Update() {
        //if (Input.GetMouseButtonDown(0)) {
            //var screenPos = Input.mousePosition;  
                //Instantiate(wavePrefab, GameObject.transform.position, Quaternion.identity);           
        //}
    }

    void Spawn() {
        GameObject obj = (GameObject)Instantiate(pillar, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
    }
}
