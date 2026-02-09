using UnityEngine;

public class FailManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            

            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
            ScoreManager.instance.GameOver();
            PipeSpawner spawner = Object.FindFirstObjectByType<PipeSpawner>();
            if (spawner != null)
            {
                spawner.StopSpawning();
            }

        }
    }
}
