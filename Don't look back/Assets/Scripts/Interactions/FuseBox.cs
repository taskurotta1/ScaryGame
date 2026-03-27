using UnityEngine;
using UnityEngine.UI;

public class FuseBox : Interactable
{
    public GameObject Escapedoor;
    private bool EscapedoorOpen;
    public bool hasFuse;
    public GameObject FuseBoxUI;
    public GameObject RedLight;
    public GameObject GreenLight;
    bool toggle2;

    public override void BaseInteract()
    {
        if (hasFuse)
        {
            EscapedoorOpen = !EscapedoorOpen;
            Escapedoor.SetActive(false);
            RedLight.SetActive(false);
            GreenLight.SetActive(true);
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
