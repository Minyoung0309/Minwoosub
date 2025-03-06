using UnityEngine;
using System;
public class BossBattleManager : MonoBehaviour
{
    public int count = 0;
    BossStatus bossStatus;
    RedWeaponStatus redWeaponStatus;
    BlueWeaponStatus blueWeaponStatus;
    void OnEnable()
    {
        count = 0;
        bossStatus = gameObject.AddComponent<BossStatus>();
        redWeaponStatus = GameObject.Find("RedWeapon").GetComponent<RedWeaponStatus>();
        blueWeaponStatus = GameObject.Find("BlueWeapon").GetComponent<BlueWeaponStatus>();
    }

  
    void FixedUpdate()
    {
       
       if(count < 100)
        {
            count++;
            bossStatus.hit(redWeaponStatus.Attack(), redWeaponStatus.denyDefence);
            if (count == 100)
            {
                Debug.Log("���� ���� ����\n");
                Debug.Log("���� ü�� : " + Math.Ceiling(bossStatus.hp));
                Time.timeScale = 0;
            }
        }
       

    }
}
