using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public float damage;

   void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(HpSystem.hp <= 1)
            {
                FindObjectOfType<GameController>().GameOver();
                FindObjectOfType<HpSystem>().TakeDamage();
                HpSystem.hp--;
                Destroy(other.gameObject);
            }
            else
            {
                HpSystem.hp--;
                FindObjectOfType<HpSystem>().TakeDamage();
                Destroy(this.gameObject);
            }
        }
    }
}
