using System.Collections;
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

    public IEnumerator GameWon()
    {
        Debug.Log("Game Won!");
        winPanel.SetActive(true);
        gameHasEnded = true;
        yield return new WaitForSeconds(5);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
