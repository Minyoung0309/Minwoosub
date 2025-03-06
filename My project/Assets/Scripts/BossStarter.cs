using UnityEditor.SceneManagement;
using UnityEngine;

public class BossStarter : MonoBehaviour
{
    public GameObject bossCanvas;
    public GameObject gatchaButton;
    public GameObject bossButton;
    BossStatus bossStatus;
    public void ShowBoss()
    {
        bossCanvas.SetActive(true);
        gatchaButton.SetActive(false);
        bossButton.SetActive(false);
    }
    public void ExitBoss()
    {
        Time.timeScale = 1;
        bossStatus = GameObject.Find("BossBattleManager").GetComponent<BossStatus>();
        Destroy(bossStatus);
        bossCanvas.SetActive(false);
        gatchaButton.SetActive(true);
        bossButton.SetActive(true);
    }
}
