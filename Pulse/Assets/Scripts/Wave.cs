using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public int segments;
    public float radius;
    LineRenderer line;

    // Use this for initialization
    void Start () {
        line = gameObject.GetComponent<LineRenderer>();

        line.numPositions = segments + 1;
        line.useWorldSpace = false;
        CreatePoints();
    }
	
	// Update is called once per frame
	void Update () {
	}

    void CreatePoints()
    {
        float x;
        float y;
        float z = 0f;

        float angle = 0f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle);
            y = Mathf.Cos(Mathf.Deg2Rad * angle);
            z = 5;
            line.SetPosition(i, new Vector3(x, y, z) * radius);
            angle += (360f / segments);
        }
    }
}

