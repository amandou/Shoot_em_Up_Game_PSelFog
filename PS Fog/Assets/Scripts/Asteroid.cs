using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody2D asteroid;
    public float speed;
    public float hp;
    void Start()
    {
        asteroid = gameObject.GetComponent<Rigidbody2D>();
        asteroid.velocity = Vector3.down * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
