using UnityEngine;

public class SceneTransitioner : MonoBehaviour
{
    // The name of the next scene to load
    public string nextSceneName;

    // This function can be called to transition to the next scene
    public void TransitionToNextScene()
    {
        GameManager.Instance.LoadNextScene(nextSceneName);
    }
}
