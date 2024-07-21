using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Text healthText;

    void Update()
    {
        healthText.text = health.ToString();
    }
}
