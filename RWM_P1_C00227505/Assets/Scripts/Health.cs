using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public GameObject HudHealth;

    public int health;

    public int numOfHearts;
          

    void Update()
    {
       
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
    }

    public void  takeDmg()
    {
        health--;
    }

    public void heal()
    {
        health++;
    }

    public void setMaxHeart(int num)
    {
        numOfHearts = num;

        HudHealth.GetComponent<Hearts>().createHearts(numOfHearts);
    }
}
