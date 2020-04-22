using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D enemy;
    public float speed;
    public float delta;
    public float hp;
    public GameObject player;

    void Start()
    {
        Movement();
    }

    // Update is called once per frame
    void Update()
    {
       ChangePosition();
    }

    void Movement()
    {
        enemy = GetComponent<Rigidbody2D>();
        enemy.velocity = Vector3.down * -speed;
    }
    
    void ChangePosition()
    {  
        float playerPosX = player.transform.position.x;
        if ((playerPosX - transform.position.x) > delta)
            enemy.velocity = new Vector3(speed,-speed,0.0f);
        else if((playerPosX - transform.position.x) < -delta)
            enemy.velocity = new Vector3(-speed, -speed,0.0f);
        else
            enemy.velocity = new Vector3(0,-speed);
    }
}
