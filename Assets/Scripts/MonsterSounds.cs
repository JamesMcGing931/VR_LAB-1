using UnityEngine;

public class MonsterSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource; 
    [SerializeField] private float minDelay = 5f;    
    [SerializeField] private float maxDelay = 15f;    

    private void Start()
    {
        StartCoroutine(PlaySoundAtRandomIntervals());
    }

    private System.Collections.IEnumerator PlaySoundAtRandomIntervals()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
