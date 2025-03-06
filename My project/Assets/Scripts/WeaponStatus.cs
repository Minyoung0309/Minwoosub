using UnityEngine;
using BansheeGz.BGDatabase;

public class WeaponStatus : MonoBehaviour
{
    public string blueWeaponGrade;
    public string blueWeapon;
    public string redWeapon;
    public string redWeaponGrade;
    public float redWeaponDamage;
    public float blueBossDamage;
    public float blueDenyDefence;
    public int redWeaponLevel;

    public double Attack()
    {
        double damage = 0;
        damage = redWeaponDamage * (1 + blueBossDamage);
        return damage;
    }
    public void initialize()
    {
        var repo = BGRepo.I;
        var userInfo = repo.GetMeta("UserInfo");
        var itemTable = repo.GetMeta("ItemTable");
        userInfo.ForEachEntity(entity =>
        {
            if (entity.Get<string>("name") == "minyoung")
            {
                blueWeapon = entity.Get<string>("weapon2");
            }
        });
        itemTable.ForEachEntity(entity =>
        {
            if (entity.Get<string>("name") == blueWeapon)
            {
                blueWeaponGrade = entity.Get<string>("grade");
            }
        });
        userInfo.ForEachEntity(entity =>
        {
            if (entity.Get<string>("name") == "minyoung")
            {
                redWeapon = entity.Get<string>("weapon");
                redWeaponLevel = entity.Get<int>("weaponlevel");
            }
        });
        itemTable.ForEachEntity(entity =>
        {
            if (entity.Get<string>("name") == redWeapon)
            {
                
                redWeaponGrade = entity.Get<string>("grade");
                redWeaponDamage = entity.Get<float>("damage");

            }
        });
    }
}

