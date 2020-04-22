using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HpSystem : MonoBehaviour
{
    public static int hp=3;
    public Color dmgColor;
    private SpriteRenderer sprite;
    

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage()
    {
        Debug.Log("Fui chamade");
        sprite.color = dmgColor;
        Invoke("Nothing",1.0f);
        sprite.color = Color.white;
    }

    public void Nothing()
    {
        Debug.Log("Nada");
    }

}
