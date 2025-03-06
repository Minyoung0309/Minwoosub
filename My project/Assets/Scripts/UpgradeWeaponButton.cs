using TMPro;
using UnityEngine;

public class UpgradeWeaponButton : MonoBehaviour
{
    public WeaponStatus weaponStatus;
    public GameManager gameManager;
    public TextMeshProUGUI level;

    public void Awake()
    {
        level.SetText(weaponStatus.redWeaponLevel.ToString());

    }
    //public void Update()
    //{
    //    int gold = gameManager.gold;
    //    int enforceGold = gameManager.enforceGold;
    //}
    public void EnfoceWeapon()
    {
        if (gameManager.gold >= gameManager.enforceGold)
        {
            weaponStatus.redWeaponLevel += 1;
            level.SetText(weaponStatus.redWeaponLevel.ToString());
            gameManager.gold = gameManager.gold - gameManager.enforceGold;
            Debug.Log(gameManager.gold);
        }
        else
        {
            Debug.Log("∞ÒµÂ ∫Œ¡∑");
        }
    }
    
}
