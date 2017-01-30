﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {
    public float spawnDelay;
    public Color checkColor;
    public GameObject pillar;
    public GameObject redPillar;
    public int spawnCount;
    Queue<GameObject> activePillars = new Queue<GameObject>();

    // Use this for initialization
    void Start() {
        InvokeRepeating("Spawn", 2, spawnDelay);
    }

    // Update is called once per frame
    void Update() {
    }

    void Spawn() {
        spawnCount++;
        GameObject obj = Instantiate(pillar.gameObject, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
        if (spawnCount >= 10)
        {
            CancelInvoke("Spawn");
            InvokeRepeating("nextSpawn", 2, spawnDelay);
        }
    }

    void nextSpawn()
    {
        GameObject obj = Instantiate(redPillar, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<LineRenderer>().startColor == gameObject.GetComponent<SpriteRenderer>().color) 
            Destroy(gameObject);
    }
}
