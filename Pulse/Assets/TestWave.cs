using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWave : MonoBehaviour {

    public Transform wavePrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0)) {
           // var screenPos = Input.mousePosition;
            //Instantiate(wavePrefab, new Vector3(screenPos.x, screenPos.y, 0), Quaternion.identity);
        //}
    }

    void OnMouseDown() {
        var screenPos = Input.mousePosition;
        Transform wave = Instantiate(wavePrefab, gameObject.transform.position, Quaternion.identity);
    }
}
