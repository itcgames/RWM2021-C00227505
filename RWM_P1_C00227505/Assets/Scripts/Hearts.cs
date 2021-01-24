using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{

    public GameObject Player;

    public GameObject sprite;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    //players max Health
    private int numOfHearts;

    public int numOfRows;
    private int numOfCol;

    public float spriteWidth;
    public float spriteHeight;

    public GameObject[,] hearts;


    public int activeHearts;

    private void Start()
    {

        numOfHearts = Player.GetComponent<Health>().numOfHearts;
        
        createHearts(numOfHearts);    
    }

    private void Update()
    {
        int num = 0;

     

        foreach (GameObject heart in hearts)
        {
            if (num < Player.GetComponent<Health>().health && num < numOfHearts)
            {
                heart.GetComponent<Image>().sprite = fullHeart;
                num++;

                activeHearts = num;
            }
            else if (num < numOfHearts)
            {
                heart.GetComponent<Image>().sprite = emptyHeart;
                num++;
            }
        }
    }


    public void createHearts(int t_heartNum = 1)
    {
        int num = 0;

        numOfCol = Mathf.CeilToInt(((float)t_heartNum / (float)numOfRows));

        hearts = new GameObject[numOfRows, numOfCol];

        foreach (GameObject heart in hearts)
        {
            Destroy(heart);
        }


        for (int x = 0; x < numOfRows; x++)
        {
            for (int y = 0; y < numOfCol; y++)
            {
                if (num < t_heartNum)
                {
                    hearts[x, y] = Instantiate(sprite, transform.position + (new Vector3(spriteWidth * y, spriteHeight * -x, 0)), Quaternion.identity, transform);
                    num++;
                }
            }
        }
    }   

}
