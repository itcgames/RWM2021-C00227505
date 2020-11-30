using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Canvas;
    [SerializeField]
    private GameObject Player;

    
    public GameObject getCanvas()
    {
        return Canvas;
    }

    public GameObject getPlayer()
    {
        return Player;
    }
}
