using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string PromptMessage;
    public GameObject UiToOpen;
    bool toggle;
    public PlayerMovement player;

    public virtual void BaseInteract()
    {
        Interact();
    }
    private protected void Interact()
    {
        toggle = !toggle;
        if (toggle == false)
        {
            UiToOpen.SetActive(false);
            player.enabled = true;
        }
        if (toggle == true)
        {
            UiToOpen.SetActive(true);
            player.enabled = false;
        }
    }

}
