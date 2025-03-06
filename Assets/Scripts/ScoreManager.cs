using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private SnakeHead snakeHead; // Ссылка на SnakeHead

    void Start()
    {   
        snakeHead = Object.FindFirstObjectByType<SnakeHead>(); // Ищем объект SnakeHead
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        if (snakeHead != null)
        {
            snakeHead.IncreaseSpeed(); // Увеличиваем скорость при увеличении счета
        }
    }
    
    public int GetScore()
    {
        // Implement the logic to return the current score
        return score; // Replace with actual score
    }
}
