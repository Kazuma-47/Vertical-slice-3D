using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealthComponent : MonoBehaviour
{
    public Slider slider;
    public int MaxHp;
    public int CurrentHealth;
    [HideInInspector]
    public string Damage;
    [SerializeField]
    private TextMeshProUGUI DamageText;
    private Animator anim;

    public void EnemyTakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;
        Damage = damage.ToString();
        DamageText.GetComponent<Animator>().SetBool("Reset", true);
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        CurrentHealth = MaxHp;
        slider.maxValue = MaxHp ;
    }
    private void Update()
    {
        slider.value = CurrentHealth;
        DamageText.text = Damage;

        if(CurrentHealth <= 0)
        {
            anim.SetBool("Dead", true);
        }
    }
}

