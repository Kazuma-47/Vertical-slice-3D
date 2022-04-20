using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTextReset : MonoBehaviour
{
    public EnemyHealthComponent healthtext;

    public void ResetText()
    {
        healthtext.Damage = "";
        GetComponent<Animator>().SetBool("Reset", false);
    }
}
