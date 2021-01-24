using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{

    [SerializeField]
    Slider m_slidier;


    public void setMaxValue(float t_maxValue)
    {
        m_slidier.maxValue = t_maxValue;
        m_slidier.value = t_maxValue;
    }

    public void SetBarBalue(float t_value)
    {
        m_slidier.value = t_value;
    }

    public float GetBarBalue()
    {
       return m_slidier.value;
    }
}
