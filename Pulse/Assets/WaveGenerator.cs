using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {

    public Transform wavePrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        Transform wave = Instantiate(wavePrefab, gameObject.transform.position, Quaternion.identity);
    }
}