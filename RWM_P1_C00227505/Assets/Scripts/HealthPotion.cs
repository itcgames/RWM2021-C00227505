using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public GameObject Player;


    public void setPlayer(GameObject t_Player)
    {
        Player = t_Player;

        
    }

    public void use()
    {
        Player.GetComponent<Health>().heal();
    }
}
