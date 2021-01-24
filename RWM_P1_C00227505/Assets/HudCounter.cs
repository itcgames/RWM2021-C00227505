using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudCounter : MonoBehaviour
{
    public int maxAmount;  

    public int amount;

    public int textSize;

    public string hudText;

    public bool noMaxAmount;

    public bool TextAdded;

    public Font font = null;

    private Text amountText;

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

        amountText.text = amount.ToString() + "/" + maxAmount.ToString();
        amountText.fontSize = textSize;
        amountText.alignment = TextAnchor.MiddleCenter;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextAdded == false)
        {
            if (noMaxAmount == true)
            {
                amountText.text = amount.ToString();
            }
            else
            {
                amountText.text = amount.ToString() + "/" + maxAmount.ToString();
            }
        }
        else
        {
            if (noMaxAmount == true)
            {
                amountText.text = hudText + amount.ToString();
            }
            else
            {
                amountText.text = hudText + amount.ToString() + "/" + maxAmount.ToString();
            }
        }
       
    }

    void addAmount(int t_num = 1)
    {
        amount += t_num;

        if (amount > maxAmount)
        {
            amount = maxAmount;
        }
    }

    void removeAmount(int t_num = 1)
    {
        amount -= t_num;

        if(amount < 0)
        {
            amount = 0;
        }
    }

    int getAmount()
    {
        return amount;
    }
}
