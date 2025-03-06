using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public int count = 0;
    public int gold = 100;
    public int enforceGold = 10;
    public BossStatus bossStatus;
    public WeaponStatus weaponStatus;
    
    void Start()
    {
        bossStatus = gameObject.AddComponent<BossStatus>();
        weaponStatus = GameObject.Find("RedWeapon").GetComponent<WeaponStatus>();
        weaponStatus.initialize();
    }
   
    // Update is called once per frame
    //void Update()
    //{
    //    count++;
    //    bossStatus.hit(redweaponStatus.Attack(), redweaponStatus.denyDefence);
    //    if(count == 100)
    //    {
    //        bossStatus.heal();
    //        count = 0;
    //        Debug.Log("현재 체력 : " + Math.Ceiling(bossStatus.hp));
    //    }

    //}
}
