using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //use unity ui

    public Slider Slider;
    public Color LowHealth;
    public Color HighHelath;
    public Vector3 Offset;

    //slider represent health 
    public void SetHealth(float health, float maxHealth)
    {
       
        Slider.gameObject.SetActive(health < maxHealth);
        Slider.value = health;
        Slider.maxValue = maxHealth;

        //change color when hit
        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(LowHealth, HighHelath, Slider.normalizedValue);
    }

    void Update()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);

    }
}
