using TMPro;
using UnityEngine;
using UnityEngine.Rendering.LookDev;

public class UpgradeWeaponButton : MonoBehaviour
{
    public WeaponStatus weaponStatus;
    public GameManager gameManager;
    public TextMeshProUGUI level;
    public TextMeshProUGUI grade;
    private string material = "minyoung's tear";
    private string[] weaponGrade = { "normal", "epic", "unique", "legendary" };

    public void Awake()
    {
        level.SetText(weaponStatus.redWeaponLevel.ToString());
        grade.SetText(weaponStatus.blueWeaponGrade);

    }
    public void EnfoceWeapon()
    {
        gameManager.enforceGold = weaponStatus.redWeaponLevel * 0.8f;
        if (gameManager.gold >= gameManager.enforceGold)
        {
            weaponStatus.redWeaponLevel += 1;
            level.SetText(weaponStatus.redWeaponLevel.ToString());
            gameManager.gold -= (int)Mathf.Round(gameManager.enforceGold);
            Debug.Log(gameManager.gold);
        }
        else
        {
            Debug.Log("골드 부족");
        }
    }
    public void UpgradeWeapon()
    {
            if (gameManager.inventory[0] != null && gameManager.inventory[0].Equals(material))
            {
                weaponStatus.blueWeaponGrade = weaponGrade[1];
            grade.SetText(weaponStatus.blueWeaponGrade);
        }
            else
            {
                Debug.Log("재료 부족");
            }
        
    }
    
}
