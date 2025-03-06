using UnityEngine;

public class EnforceStarter : MonoBehaviour
{
    public GameObject enforceCanvas;
    public GameObject gatchaButton;
    public GameObject bossButton;
    public GameObject enforceButton;

    public void ShowEnforce()
    {
        enforceCanvas.SetActive(true);
        enforceButton.SetActive(false);
        gatchaButton.SetActive(false);
        bossButton.SetActive(false);
    }
    public void ExitEnforce()
    {
        enforceCanvas.SetActive(false);
        enforceButton.SetActive(true);
        gatchaButton.SetActive(true);
        bossButton.SetActive(true);
    }
}
