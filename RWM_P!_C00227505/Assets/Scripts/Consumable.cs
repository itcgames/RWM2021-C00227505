using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    public GameObject Player;

    public GameObject ConsumablePrefab;

    public int amount;

    public bool usable;

    private Text amountText;

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
      
        amountText.text = "X" + amount.ToString() ;
        amountText.fontSize = 24;
       

        float Width = ConsumablePrefab.GetComponent<RectTransform>().rect.width;

        float height = ConsumablePrefab.GetComponent<RectTransform>().rect.height * 0.60f;

        Instantiate(ConsumablePrefab, transform.position - new Vector3(Width, -height,0), Quaternion.identity, transform);


    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = "X" + amount.ToString();


        if (Input.GetMouseButtonDown(0))
        {
            use();
        }
    }

    public void AddAmount()
    {
        amount++;
    }

    public void use(int t_num = 1)
    {
        if (usable == true)
        {
            if (ConsumablePrefab.GetComponent<HealthPotion>() != null)
            {
                ConsumablePrefab.GetComponent<HealthPotion>().setPlayer(Player);
            }

            if (amount > 0)
            {
                if (ConsumablePrefab.GetComponent<HealthPotion>() != null)
                {
                    if (Player.GetComponent<Health>().health < Player.GetComponent<Health>().numOfHearts)
                    {
                        ConsumablePrefab.GetComponent<HealthPotion>().use();

                        amount -= t_num;
                    }
                }
            }
        }
    }
}
