using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseOnCollision : MonoBehaviour
{
    public string ballTag = "Ball";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(ballTag))
        {
            ReloadLevel();
        }
    }

    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}