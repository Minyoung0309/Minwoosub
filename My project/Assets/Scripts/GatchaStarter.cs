using UnityEngine;
using UnityEngine.UI;

public class GatchaStarter : MonoBehaviour
{
    public GameObject gatchaCanvas;
    public GameObject gatchaButton;
    public GameObject bossButton;
    public void ShowGatcha()
    {
        gatchaCanvas.SetActive(true);
        gatchaButton.SetActive(false);
        bossButton.SetActive(false);
    }
    public void ExitGatcha()
    {
        gatchaCanvas.SetActive(false);
        gatchaButton.SetActive(true);
        bossButton.SetActive(true);
    }
}
