using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    private List<GameObject> Inventory = new List<GameObject>();

    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    public float slotSize;

    private void Awake()
    {
        itemSlotContainer = transform.Find("InvenSlot");
        itemSlotTemplate = itemSlotContainer.Find("InvenSlotTemplate");
    }

    public void setInventory(List<GameObject> t_inventory)
    {
        Inventory = t_inventory;

        refreshInventory();
    }


    public void refreshInventory()
    {

        foreach (Transform child in itemSlotContainer)
        {
            if(child == itemSlotTemplate)
            {
                continue;
            }
            else
            {
                Destroy(child.gameObject);
            }
        }


        int x = 0;
        int y = 0;

        float cellSize = slotSize;

        foreach (GameObject item in Inventory)
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * cellSize, y * cellSize);


            itemSlotRectTransform.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;

            x++;

            if (x > 5)
            {
                x = 0;
                y--;
            }

        }
    }

    //code to activate the inventory and pause time
//     if (Input.GetKeyDown(KeyCode.I))
//        {
//            foreach (Transform child in UI_Invent.transform)
//            {
//                if (child.gameObject.active)
//                {
//                    child.gameObject.SetActive(false);
//                    Time.timeScale = 1.0f;
//                }
//                else
//                {
//                  child.gameObject.SetActive(true);
//                  Time.timeScale = 0.0f;
//                }
//            }
//        }

}
