using UnityEngine;
using UnityEngine.Audio;

public class Goal : MonoBehaviour
{
    public AudioClip victorySound;
    public AudioSource audioSource;
    //private LevelManager levelManager;

    private void Start()
    {
        //levelManager = FindObjectOfType<LevelManager>();
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            audioSource.PlayOneShot(victorySound);
            //levelManager.LoadNextLevel();
        }
    }
}
