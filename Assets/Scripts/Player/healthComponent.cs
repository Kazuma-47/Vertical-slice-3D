using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthComponent : MonoBehaviour
{
  
    public int health = 110;
    public Slider slider;
    public int CurrentHealth;


    private void Start()
    {
        CurrentHealth = health;
        SetHealth(health);
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;
    }


    private void Update()
    {
        slider.value = CurrentHealth;

        if (CurrentHealth == 0)
        {
            //Game over Screen
            Destroy(gameObject);
        }
    }
}
