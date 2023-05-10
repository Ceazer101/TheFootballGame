using UnityEngine;
using UnityEngine.Audio;

public class Goal : MonoBehaviour
{

    public float delay = 6f;

    public MusicController musicController;

    public LevelManager levelManager;
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
            musicController.StopBackgroundMusic();
            audioSource.PlayOneShot(victorySound);
            Invoke("loadLevel", delay);
        }
    }


    private void loadLevel() {
        levelManager.LoadNextLevel();
    }
}
