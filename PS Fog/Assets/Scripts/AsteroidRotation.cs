﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform asteroid;

    // Update is called once per frame
    void Update()
    {
        asteroid.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
