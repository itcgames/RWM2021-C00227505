using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTest : MonoBehaviour
{

    public UIInventory UI_Invent;

    public Bar staminaBar;

    public List<GameObject> inventory;

    public float Stamina;

    // Start is called before the first frame update
    void Start()
    {
        UI_Invent.setInventory(inventory);

        staminaBar.setMaxValue(Stamina);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (Transform child in UI_Invent.transform)
            {
                if (child.gameObject.active)
                {
                    child.gameObject.SetActive(false);
                    Time.timeScale = 1.0f;
                }
                else
                {
                    child.gameObject.SetActive(true);
                    Time.timeScale = 0.0f;
                }
            }
        }

        staminaBar.SetBarBalue(Stamina);
    }

    public void useStamina()
    {
        Stamina--;

        staminaBar.SetBarBalue(Stamina);
    }
}
