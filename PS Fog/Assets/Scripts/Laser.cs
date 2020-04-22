using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Asteroid asteroid;
    public Enemy enemy;
    public float damage;
    public float speed;

    Rigidbody2D laser;
    
    void Start()
    {
        laser = gameObject.GetComponent<Rigidbody2D>();
        laser.velocity = new Vector3(0.0f, speed, 0.0f);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Asteroid") )
        {
            ScoreScript.score += asteroid.hp;
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
        if (collider.gameObject.CompareTag("Enemy"))
        {
            ScoreScript.score += enemy.hp;
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
        
    }
    
}
