using System;
using BansheeGz.BGDatabase;
using UnityEngine;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour
{
    public BossStatus bossStatus;
    public WeaponStatus weaponStatus;
    public int count = 0;
    public int gold;
    public float enforceGold;
    public string[] inventory = { "minyoung's tear" };
    
    
    void Start()
    {
        var repo = BGRepo.I;
        var userInfo = repo.GetMeta("UserInfo");
        var itemTable = repo.GetMeta("ItemTable");
        userInfo.ForEachEntity(entity =>
        {
            if (entity.Get<string>("name") == "minyoung")
            {
                gold = entity.Get<int>("gold");
            }
        });
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
