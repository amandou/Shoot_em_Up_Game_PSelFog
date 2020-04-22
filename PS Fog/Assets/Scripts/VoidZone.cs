using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "Laser" || collider.tag == "Asteroid")
            Destroy(collider.gameObject);
        if(collider.tag == "Enemy")
            collider.gameObject.SetActive(false);
    }
}
