using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using BansheeGz.BGDatabase;

public class EnforceManager : MonoBehaviour
{
    public Button enforceWeaponButton;
    public Button upgradeWeaponButton;
    public GameManager gameManager;
    public bool checkGold = false;
    public bool checkMaterial = false;

    public void Awake()
    {

        enforceWeaponButton = GameObject.Find("EnforceWeaponButton").GetComponent<Button>();
        upgradeWeaponButton = GameObject.Find("UpgradeWeaponButton").GetComponent<Button>();


    }
    public bool ActivationBox()
    {
        Debug.Log("강화후 돈: " + gameManager.gold + ", 강화에 사용된 돈: " + gameManager.enforceGold);

        if(gameManager.gold >= gameManager.enforceGold)
        {
            return enforceWeaponButton.interactable = true;
            
        }
        else
        {
            return enforceWeaponButton.interactable = false;
        }
    }
    public void Update()
    { 
        ActivationBox();
    }
}
