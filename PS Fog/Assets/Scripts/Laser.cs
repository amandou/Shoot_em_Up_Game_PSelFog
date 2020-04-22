using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Asteroid asteroid;
    public Enemy enemy;
    public float damage;
    public float speed;
    public GameObject[] items;
    public static int positionItem;

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
            if( Random.Range(0,100) / 2 == 0 )
            {
                Asteroid asteroid = collider.GetComponent<Asteroid>();
                positionItem = Random.Range(0,items.Length);
                Instantiate(items[positionItem], 
                asteroid.transform.position, Quaternion.identity);
            }
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
        if (collider.gameObject.CompareTag("Enemy"))
        {
            ScoreScript.score += enemy.hp;
            if( Random.Range(0,100) / 2 == 0 )
            {
                Enemy enemy = collider.GetComponent<Enemy>();
                positionItem = Random.Range(0,items.Length);
                Instantiate(items[positionItem], 
                enemy.transform.position, Quaternion.identity);
            }
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
        
    }
    
}
