using System;
using UnityEngine;
using UnityEngine.UIElements;

public class BossStatus : MonoBehaviour
{
    public HealthBarController healthBarController;
    public float hp = 10000;
    public float maxhp = 10000;
    public int count = 0;
    public int defence = 1;
   
    public void heal()
    {
        hp = maxhp;
    }

    public void hit(float damage, float denyDefence)
    {
        if (hp > 0)
        {
            damage = (damage * (1 - defence * (1 - denyDefence)));
            hp -= damage;

        }
        if( hp < 0)
        {
            Debug.Log("´ÙÀÌ");
        }
        
    }
    
    public void Initialize(float maxStamina)
    {
        maxhp = maxStamina;
        hp = maxhp;
        healthBarController.UpdateHealth(hp / maxhp);
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }

        healthBarController.UpdateHealth(hp / maxhp);
    }
}
