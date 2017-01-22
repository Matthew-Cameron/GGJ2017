using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public float spawnDelay;
    public Color checkColor;
    public GameObject pillar;
    public Transform wavePrefab;
    Queue<GameObject> activePillars = new Queue<GameObject>();

    // Use this for initialization
    void Start() {
        InvokeRepeating("Spawn", 2, spawnDelay);
        checkColor = Color.red;
    }

    // Update is called once per frame
    void Update() {
    }

    void Spawn() {
        GameObject obj = Instantiate(pillar, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<LineRenderer>().startColor == checkColor)
            Destroy(gameObject);
    }
}
