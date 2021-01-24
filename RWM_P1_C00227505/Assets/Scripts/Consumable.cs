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


    public int textSize;

    public Font font = null;

    // Start is called before the first frame update
    void Start()
    { 
        gameObject.AddComponent<Text>();
        amountText = gameObject.GetComponent<Text>();
      
        if (font == null)
        {
            Font arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
            amountText.font = arial;
        }
        else
        {
            amountText.font = font;
        }

        amountText.text = "X " + amount.ToString();
        amountText.fontSize = textSize;
        amountText.alignment = TextAnchor.MiddleCenter;


        // Instantiate(ConsumablePrefab, transform.position - new Vector3(Width, -height,0), Quaternion.identity, transform);

        float Width = 30;

        Instantiate(ConsumablePrefab, transform.position - new Vector3(Width, 0, 0), Quaternion.identity, transform);

        
    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = "X " + amount.ToString();
    }

    public void AddAmount(int num = 1)
    {
        amount += num;
    }

    public void removeAmount(int num = 1)
    {
        if (amount - num >= 0)
        {
            amount -= num;
        }
    }

    public void setAmount(int num)
    {
        amount = num;
    }

    public int getAmount()
    {
        return amount;
    }

    public void use(int t_num = 1)
    {
        if (amount > 0)
        {
            if (amount - t_num >= 0)
            {
                ConsumablePrefab.GetComponent<HealthPotion>().setPlayer(Player);

                ConsumablePrefab.GetComponent<HealthPotion>().use();
                       
                amount -= t_num;
            }
        }
    }
}
