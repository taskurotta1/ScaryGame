using System.Collections;
using UnityEngine;

public class EndCreditManager : MonoBehaviour
{
    public AnimationClip endCredits;
    AnimationClip Play;
    private void Start()
    {
        StartCredits();
    }

    private void StartCredits()
    {
        Play = endCredits;
    }

}
