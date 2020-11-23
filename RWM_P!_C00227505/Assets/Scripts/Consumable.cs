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
        amountText.fontSize = 24;
       

        float Width = ConsumablePrefab.GetComponent<RectTransform>().rect.width;

        float height = ConsumablePrefab.GetComponent<RectTransform>().rect.height * 0.60f;

        Debug.Log(Width + " " + height);

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

    public void use()
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

                    amount--;
                }
            }
        }
    }
}
