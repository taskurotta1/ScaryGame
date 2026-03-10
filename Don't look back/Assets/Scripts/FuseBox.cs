using UnityEngine;
using UnityEngine.UI;

public class FuseBox : Interactable
{
    public GameObject Escapedoor;
    private bool EscapedoorOpen;
    public bool hasFuse;
    public GameObject FuseBoxUI;
    bool toggle2;

    public override void BaseInteract()
    {
        if (hasFuse)
        {
            EscapedoorOpen = !EscapedoorOpen;
            Escapedoor.SetActive(false);
            toggle2 = !toggle2;
            if (toggle2 == false)
            {
                FuseBoxUI.SetActive(false);
                player.enabled = true;
            }
            if (toggle2 == true)
            {
                FuseBoxUI.SetActive(true);
                player.enabled = false;
            }
        }
        else
        {
            Interact();
        }
    }
}
