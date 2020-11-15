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



    private void Start()
    {
               

        numOfHearts = Player.GetComponent<Health>().numOfHearts;



        createHearts();
       

     
    }

    private void Update()
    {
        int num = 0;

        for (int i = 0; i < numOfRows; i++)
        {
            for (int y = 0; y < numOfCol; y++)
            {
                if (num < Player.GetComponent<Health>().health && num < numOfHearts)
                {
                    hearts[i, y].GetComponent<Image>().sprite = fullHeart;
                    num++;
                }
                else if (num < numOfHearts)
                {
                    hearts[i, y].GetComponent<Image>().sprite = emptyHeart;
                    num++;
                }

            }
        }
    }


    private void createHearts()
    {
        int num = 0;

        numOfCol = Mathf.CeilToInt(((float)numOfHearts / (float)numOfRows));

        hearts = new GameObject[numOfRows, numOfCol];

        for (int i = 0; i < numOfRows; i++)
        {
            for (int y = 0; y < numOfCol; y++)
            {
                if (num < numOfHearts)
                {
                    hearts[i, y] = Instantiate(sprite, transform.position + (new Vector3(spriteWidth * y, spriteHeight * -i, 0)), Quaternion.identity, transform);
                    num++;
                }

            }
        }
    }

}
