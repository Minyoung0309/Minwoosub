using TMPro;
using UnityEngine;

public class RedStatusSync : MonoBehaviour
{
    public WeaponStatus weaponStatus;
    public TextMeshProUGUI rname;
    public TextMeshProUGUI level;
    public TextMeshProUGUI weaponDamage;
    public void OnEnable()
    {
        rname.SetText(weaponStatus.redWeapon);
        level.SetText(weaponStatus.redWeaponLevel.ToString());
        weaponDamage.SetText(weaponStatus.redWeaponDamage.ToString());
    }
}
