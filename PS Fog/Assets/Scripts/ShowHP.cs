using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHP : MonoBehaviour
{
    public Text HpText;

    void Start()
    {
        HpText = GetComponent<Text>();
    }

    void Update()
    {
        HpText.text = ""+HpSystem.hp;
    }
}
