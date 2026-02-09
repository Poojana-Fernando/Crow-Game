using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public GameObject failMenuPanel;

    void Start()
    {
        if (failMenuPanel != null)
            failMenuPanel.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("PIPE HIT");

            Time.timeScale = 0f;

            if (failMenuPanel != null)
                failMenuPanel.SetActive(true);

            ScoreManager.instance.GameOver();
        }
    }
}
