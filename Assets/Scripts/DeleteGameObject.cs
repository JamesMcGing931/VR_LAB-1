using UnityEngine;

public class DeleteGameObject : MonoBehaviour
{
    [SerializeField] private GameObject target;

    public void DeleteTarget()
    {
        if (target != null)
        {
            Destroy(target);
            Debug.Log($"{target.name} has been deleted.");
        }
        else
        {
            Debug.LogWarning("Target GameObject is not assigned or already destroyed.");
        }
    }
}
