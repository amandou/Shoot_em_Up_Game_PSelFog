﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float speed;
    public Renderer bgRenderer;

    void Update()
    {
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.deltaTime * speed);
    }
}

