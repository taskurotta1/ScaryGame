using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string PromptMessage;

    public void BaseInteract()
    {
        Interact();

    }

    protected virtual void Interact()
    {

    }
}
