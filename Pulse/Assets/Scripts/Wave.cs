﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public Transform wavePrefab;

    public float ThetaScale = 0.01f;
    public float radius = .01f;
    private int Size;
    private LineRenderer LineDrawer;
    private float Theta = 0f;

    // Use this for initialization
    void Start()
    {
        LineDrawer = GetComponent<LineRenderer>();
        LineDrawer.material = new Material(Shader.Find("Particles/Additive"));
        LineDrawer.startColor = Node.waveColor;
        LineDrawer.endColor = Node.waveColor;
        LineDrawer.startWidth = 0.5f;
        LineDrawer.endWidth = 0.5f;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Size = (int)((1f / ThetaScale) + 1f);
        LineDrawer.numPositions = Size;
        radius = radius + 0.07f;
        for (int i = 0; i < Size; i++)
        {
            Theta += (2.0f * Mathf.PI * ThetaScale);
            float x = radius * Mathf.Cos(Theta);
            float y = radius * Mathf.Sin(Theta);
            LineDrawer.SetPosition(i, new Vector3(x, y, -2));
            CircleCollider2D coll = gameObject.GetComponent<CircleCollider2D>();
            coll.radius = radius;

        }
    }

}
