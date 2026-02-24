using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject winPanel;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            
        }
    }

    public void GameWon()
    {
        Debug.Log("Game Won!");
        winPanel.SetActive(true);
        gameHasEnded = true;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
