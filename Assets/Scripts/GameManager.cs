using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TextMeshProUGUI finalScoreText;
    private bool isGameOver = false;

    public void GameOver(int score)
    {
        if (isGameOver) return;
        isGameOver = true;
        gameOverPanel.SetActive(true);
        finalScoreText.text = "Your Score: " + score;
    }


    public void RestartGame()
    {
        Time.timeScale = 1; // Включаем игру
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
