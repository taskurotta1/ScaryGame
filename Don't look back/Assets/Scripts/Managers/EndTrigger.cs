using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        StartCoroutine(gameManager.GameWon());
    }
}
