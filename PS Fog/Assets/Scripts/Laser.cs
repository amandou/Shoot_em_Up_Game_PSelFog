using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    Rigidbody2D laser;
    public float damage;
    public float speed;
    public Asteroid asteroid;
    void Start()
    {
        laser = gameObject.GetComponent<Rigidbody2D>();
        laser.velocity = new Vector3(0.0f, speed, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {//and collider.gameObject.hp <= 0  
        if (collider.gameObject.CompareTag("Asteroid") )
        {
            ScoreScript.score += asteroid.scoreValue;
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
    }
}
