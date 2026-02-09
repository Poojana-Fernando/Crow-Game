using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public float score = 0f; // float for milliseconds
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;

    bool isGameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (isGameOver) return;

        // 1 millisecond = 1 point
        score += Time.deltaTime * 1000f;

        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = ((int)score).ToString();
    }

    public void GameOver()
    {
        isGameOver = true;

        if (finalScoreText != null)
            finalScoreText.text = "Score: " + ((int)score);
    }
}
