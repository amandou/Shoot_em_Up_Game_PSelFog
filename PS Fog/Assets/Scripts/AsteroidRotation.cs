﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
        public float speed;
        public Transform asteroid;
        
        void Update()
        {
            asteroid.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
}
