using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {
    public float spawnDelay;
    public Color checkColor;
    public GameObject pillar;
    public GameObject redPillar;
    public int levelCount;
    public int levelCheck;
    Queue<GameObject> activePillars = new Queue<GameObject>();

    // Use this for initialization
    void Start() {
        levelCount = 5;
        levelCheck = 5;
        Spawn();
    }

    // Update is called once per frame
    void Update() {
    }

    void Spawn() {
        for (int i = 0; i < levelCount; i++) {
            GameObject obj = Instantiate(pillar.gameObject, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        }
    }

    void nextSpawn()
    {
        GameObject obj = Instantiate(redPillar, new Vector3(Random.Range(-18, 18), Random.Range(-25, 25), 0), Quaternion.identity);
        activePillars.Enqueue(obj);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.GetComponent<LineRenderer>().startColor == gameObject.GetComponent<SpriteRenderer>().color) {
            Destroy(gameObject);
            levelCheck--;
        }

 //       if (levelCheck == 0)
  //          UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");

    }
}
