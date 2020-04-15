using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    Rigidbody2D laser;
    public float damage = 10;
    public float speed = 10;


    void Start()
    {
        laser = gameObject.GetComponent<Rigidbody2D>();
        laser.velocity = new Vector3(0.0f, speed, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {//and collider.gameObject.hp <= 0  
        if (collider.gameObject.CompareTag("Asteroid") )
        {
            //animação de explosão do asteroide se der tempo
            Destroy(collider.gameObject); // game obj do colider que colideiu com a bala
            Destroy(this.gameObject); // referencia a bala
        }
    }
}
