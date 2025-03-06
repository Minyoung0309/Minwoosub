using UnityEngine;

public class BlueWeaponStatus : MonoBehaviour
{
    public new string name = "blueweapon";
    public int level = 1;
    public float weaponDamage = 1;
    public float bossDamage = 0;
    public float denyDefence = 0;

    public float Attack()
    {
        float damage = 0;
        damage = weaponDamage * (1 + bossDamage);
        return damage;
    }
    public void initialize(int level, int bossDamage, float denyDefence)
    {
        this.level = level;
        weaponDamage = level * 3;
        this.bossDamage = bossDamage;
        this.denyDefence = denyDefence;
    }

}
