using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    public GameObject winPanel;

    private IEnumerator OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            winPanel.SetActive(true);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(currentScene.name);
        }
    }
}

