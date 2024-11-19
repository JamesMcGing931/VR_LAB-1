using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverZone : MonoBehaviour
{
    public GameObject target; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            TriggerGameOver();
        }
    }

    private void TriggerGameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
