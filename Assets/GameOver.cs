using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverZone : MonoBehaviour
{
    public GameObject target; // The player object

    private void OnTriggerEnter(Collider other)
    {
        // When the player enters the game over zone (box collider)
        if (other.gameObject == target)
        {
            Debug.Log("Player entered Game Over Zone!");
            TriggerGameOver();
        }
    }

    private void TriggerGameOver()
    {
        // Here you can add any game over logic (like displaying UI, etc.)
        Debug.Log("Game Over!");

        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
