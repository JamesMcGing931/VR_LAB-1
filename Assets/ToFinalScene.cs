using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject; // The object to detect (e.g., player)

    [SerializeField] private int sceneIndex = 2; // Scene index to load

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the collider
        if (other.gameObject == targetObject)
        {
            // Load the scene with the specified index
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
