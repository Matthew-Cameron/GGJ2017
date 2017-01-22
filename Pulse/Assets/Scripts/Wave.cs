using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{

    public float ThetaScale = 0.01f;
    public float radius = 3f;
    private int Size;
    private LineRenderer LineDrawer;
    private float Theta = 0f;

    // Use this for initialization
    void Start()
    {
        LineDrawer = GetComponent<LineRenderer>();
        LineDrawer.material = new Material(Shader.Find("Particles/Additive"));
        LineDrawer.startColor = Color.red;
        LineDrawer.endColor = Color.red;
        LineDrawer.startWidth = 0.1f;
        LineDrawer.endWidth = 0.1f;
        Destroy(gameObject, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Size = (int)((1f / ThetaScale) + 1f);
        LineDrawer.numPositions = Size;
        radius = radius + 0.1f;
        for (int i = 0; i < Size; i++)
        {
            Theta += (2.0f * Mathf.PI * ThetaScale);
            float x = radius * Mathf.Cos(Theta);
            float y = radius * Mathf.Sin(Theta);
            LineDrawer.SetPosition(i, new Vector3(x, y, -2));

        }
    }

}
