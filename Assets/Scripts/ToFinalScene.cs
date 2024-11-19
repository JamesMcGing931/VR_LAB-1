using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObject; 

    [SerializeField] private int sceneIndex = 2; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
