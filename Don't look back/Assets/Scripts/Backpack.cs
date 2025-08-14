using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    public GameObject BackpackUI;
    bool toggle;
    public PlayerMovement player;
    
    public void openCloseBackpack()
    {
        toggle = !toggle;
        if (toggle == false);
        {
            BackpackUI.SetActive(false);
            player.enabled = true;
        }
        if (toggle == true)
        {
            BackpackUI.SetActive(true);
            player.enabled = false;
        }
    }
}
