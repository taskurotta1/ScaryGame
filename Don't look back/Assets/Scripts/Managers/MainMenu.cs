using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneIndex;
    public GameObject ControlsUI;
    public GameObject MainMenuUI;

    private void Start()
    {
        unlockCursor();
    }

    void unlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Controls()
    {
        MainMenuUI.SetActive(false);
        ControlsUI.SetActive(true);
    }
    public void Back()
    {
        ControlsUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
    public void Continue()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
