using UnityEngine;

public class Menumanager : MonoBehaviour
{

    public GameObject MenuPanel;
    void Start()
    {
        Time.timeScale = 0f;
        MenuPanel.SetActive(true);
        
    }

    public void startgame()
    {
        Time.timeScale = 1f;
        MenuPanel.SetActive(false);
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
