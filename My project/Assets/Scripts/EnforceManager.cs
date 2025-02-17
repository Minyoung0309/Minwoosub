using UnityEngine;
using UnityEngine.UI;

public class EnforceManager : MonoBehaviour
{
    public Button enforceWeaponButton;
    public GameManager gameManager;

    public void Awake()
    {
        enforceWeaponButton = GameObject.Find("EnforceWeaponButton").GetComponent<Button>();
    }
    public void Update()
    {
        Debug.Log("��ȭ�� ��: " + gameManager.gold + ", ��ȭ�� ���� ��: " + gameManager.enforceGold);
        
        if (gameManager.gold >= gameManager.enforceGold)
        {
            enforceWeaponButton.interactable = true;
        }
        else
        {
            enforceWeaponButton.interactable=false;
        }
    }
}
