using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;

public class Hearts : MonoBehaviour
{

    public GameObject Player;

    public GameObject sprite;
    private int numOfHearts;
    public int numOfRows;

    private int numOfCol;

    public float spriteWidth;
    public float spriteHeight;

    public GameObject[,] hearts;



    private void Start()
    {

        int num = 0;

        numOfHearts = Player.GetComponent<Health>().numOfHearts;

        numOfCol = Mathf.CeilToInt(((float)numOfHearts / (float)numOfRows));

        hearts = new GameObject[numOfRows,numOfCol];

       
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

    private void Update()
    {
        Player.GetComponent<Health>().hearts = this.hearts;
    }

}
