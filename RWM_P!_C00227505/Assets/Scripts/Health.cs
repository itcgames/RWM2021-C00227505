using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;

    public int numOfHearts;

    public GameObject[,] hearts;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {

            if(health > numOfHearts)
            {
                health = numOfHearts;
            }


            if(i < health)
            {
                //hearts[i].enabled = true;
                //hearts[i].sprite = FullHeart;
            }
            else
            {
                //hearts[i].enabled = false;
            }


            //if(i < numOfHearts)
            //{
            //    hearts[i].enabled = true;
            //}
            //else
            //{
            //    hearts[i].enabled = false;
            //}
        }
    }
}
