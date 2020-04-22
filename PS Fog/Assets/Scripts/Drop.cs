using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Laser laser;
    private void OnTriggerEnter2D(Collider2D other) 
    {   
        if(other.gameObject.tag == "Player")
        {
            SetItem(Laser.positionItem);
            Destroy(this.gameObject);
        }
    }

    public void SetItem(int pos)
    {
        if(laser.items[pos] == (gameObject.name =="Battery"))
        {
            HpSystem.hp++;
        }

    }
}
