using UnityEngine;

public class Fuse : Interactable
{
    public GameObject FuseBoxObject;
    public override void BaseInteract()
    {  
        FuseBox fuseBox = FuseBoxObject.GetComponent<FuseBox>();
        if (fuseBox != null)
        {
            fuseBox.hasFuse = true;
        }
        Interact();
    }
}
