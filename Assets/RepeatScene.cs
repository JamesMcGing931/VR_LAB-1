using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoadSceneByBuildIndex : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 7f; // Delay in seconds

    private void Start()
    {
        // Start the countdown to load the next scene
        Invoke("LoadNextScene", delayBeforeLoading);
    }

    private void LoadNextScene()
    {
        // Load the scene with build index 1
        if (SceneManager.sceneCountInBuildSettings > 1)
        {
            SceneManager.LoadScene(1); // Load the scene at index 1
        }
        else
        {
            Debug.LogError("Scene with build index 1 does not exist in Build Settings.");
        }
    }
}
