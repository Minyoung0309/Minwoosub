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
        Debug.Log("��ȭ�� ��: " + gameManager.gold + ", ��ȭ�� ���� ��: " + gameManager.enforceGold);

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
