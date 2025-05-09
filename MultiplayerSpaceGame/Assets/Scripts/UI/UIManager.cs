using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject hud;
    public GameObject notificationPanel;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        hud.SetActive(false);
        notificationPanel.SetActive(false);
    }

    public void ShowHUD()
    {
        mainMenu.SetActive(false);
        hud.SetActive(true);
        notificationPanel.SetActive(false);
    }

    public void ShowNotification(string message)
    {
        notificationPanel.SetActive(true);
        // Assume there's a Text component in the notificationPanel to display the message
        notificationPanel.GetComponentInChildren<UnityEngine.UI.Text>().text = message;
    }

    public void HideNotification()
    {
        notificationPanel.SetActive(false);
    }
}