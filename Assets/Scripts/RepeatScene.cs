using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoadSceneByBuildIndex : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 7f; 

    private void Start()
    {
        Invoke("LoadNextScene", delayBeforeLoading);
    }

    private void LoadNextScene()
    {
        if (SceneManager.sceneCountInBuildSettings > 0)
        {
            SceneManager.LoadScene(0); 
        }
        else
        {
            Debug.LogError("Scene with build index 1 does not exist in Build Settings.");
        }
    }
}
