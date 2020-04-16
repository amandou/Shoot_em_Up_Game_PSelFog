using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float maxY,minY;
    public void borda(Rigidbody2D player)
    {
        player.position = new Vector3(
           player.position.x, 
           Mathf.Clamp(player.position.y,minY,maxY), 
           0.0f);
    }
}
public class Player : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    //public float hp;
    public Boundary boundary;
    public GameObject laser;
    public Transform laserSpawn;
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();

        speed = 6;
    }
    void FixedUpdate() 
    {
       PlayerController(); 
    }



    public void PlayerController()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        playerRB.velocity = new Vector3(moveHorizontal*speed,moveVertical*speed,0.0f);
        boundary.borda(playerRB);
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, 
            (laserSpawn.position + new Vector3(0.0f, 1.0f, 0.0f)), 
            laserSpawn.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("b key was pressed.");
        }
    }

}
