using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public Asteroid asteroid;

    private void OnTriggerEnter2D(Collider2D collider)
    {//and collider.gameObject.hp <= 0  
        if (collider.gameObject.CompareTag("Asteroid") )
        {
            ScoreScript.score += asteroid.hp;
            Destroy(collider.gameObject);
            Destroy(this.gameObject); 
        }
        
    }
}
