using System;
using UnityEngine;
using UnityEngine.UIElements;

public class BossStatus : MonoBehaviour
{
    public double hp = 10000;
    public double maxhp = 10000;
    public int count = 0;
    public int defence = 1;
   
    public void heal()
    {
        hp = maxhp;
    }

    public void hit(double damage, double denyDefence)
    {
        if (hp > 0)
        {
            damage = (damage * (1 - defence * (1 - denyDefence)));
            hp -= damage;
            Debug.Log("현재 체력 : " + Math.Ceiling(hp));

        }
        if( hp < 0)
        {
            Debug.Log("다이");
        }
        
    }
}
