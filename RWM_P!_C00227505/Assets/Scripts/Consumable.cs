using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    public GameObject Player;

    public GameObject ConsumablePrefab;

    public int amount;

    private Text amountText;

    private Font arial;

    // Start is called before the first frame update
    void Start()
    {
   
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        gameObject.AddComponent<Text>();
        amountText = gameObject.GetComponent<Text>();
        amountText.font = arial;
        amountText.text = "X" + amount.ToString() ;
        amountText.fontSize = 48;
        //amountText.GetComponent<RectTransform>().localPosition += new Vector3(40, 0, 0);

        Instantiate(ConsumablePrefab, transform.position - new Vector3(60, -20,0), Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = "X" + amount.ToString();
    }

    public void use()
    {
        //insert use code here
        //e.g
        Player.GetComponent<Health>().heal();
    }
}
