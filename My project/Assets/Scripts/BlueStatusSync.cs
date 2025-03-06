using TMPro;
using UnityEngine;

public class BlueStatusSync : MonoBehaviour
{
    public WeaponStatus weaponStatus;
    public TextMeshProUGUI bname;
    public TextMeshProUGUI level;
    public TextMeshProUGUI bossDamge;
    public TextMeshProUGUI denyDefence;
    public void OnEnable()
    {
        bname.SetText(weaponStatus.blueWeapon);
        level.SetText(weaponStatus.blueWeaponGrade);
        bossDamge.SetText(weaponStatus.blueBossDamage.ToString());
        denyDefence.SetText(weaponStatus.blueDenyDefence.ToString());
    }
}
