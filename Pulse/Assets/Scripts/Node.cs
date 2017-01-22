using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public static Color waveColor;

    public Transform wavePrefab;

    RaycastHit hit; // initializing the raycasthit
                    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var myRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        myRay.z = 0;
        if (Input.GetMouseButtonDown(0))
        {// what to do if i press the left mouse button
            waveColor = Color.red;
            Instantiate(wavePrefab, myRay, Quaternion.identity);
        }
        if (Input.GetMouseButtonDown(1))
        {
            waveColor = Color.blue;
            Instantiate(wavePrefab, myRay, Quaternion.identity);
        }

    }


}