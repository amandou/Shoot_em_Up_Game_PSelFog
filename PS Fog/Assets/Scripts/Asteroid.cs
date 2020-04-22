using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody2D asteroid;
    public float hp;
    public float speed;

    void Start()
    {
        asteroid = gameObject.GetComponent<Rigidbody2D>();
        asteroid.velocity = new Vector3(0.0f, speed, 0.0f) * Time.deltaTime;
    }

}
