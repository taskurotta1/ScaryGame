using UnityEngine;

public class FuseBox : Interactable
{
    public GameObject Escapedoor;
    private bool EscapedoorOpen;

    protected override void Interact()
    {
        EscapedoorOpen = !EscapedoorOpen;
        Escapedoor.SetActive(false);
    }
}
