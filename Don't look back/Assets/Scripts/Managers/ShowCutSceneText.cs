using System.Collections;
using UnityEngine;

public class ShowCutSceneText : MonoBehaviour
{
    public AnimationClip PlayCutScene;

    AnimationClip Play;

    private void Start()
    {
        StartCutScene();
    }
    private void StartCutScene()
    {
        Play = PlayCutScene;
    }
    
}
