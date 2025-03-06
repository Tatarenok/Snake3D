using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    public float speed = 3f;
    public float turnSpeed = 90f;
    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver) return; // Останавливаем движение, если игра окончена

        // Движение вперед
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Управление поворотами
        float turn = Input.GetAxis("Horizontal"); // Лево/право (A/D)
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body")) // Если врезались в хвост
        {
            Debug.Log("Game Over! You hit yourself!");
            isGameOver = true;
            Object.FindFirstObjectByType<GameManager>().GameOver(Object.FindFirstObjectByType<ScoreManager>().GetScore());
            Time.timeScale = 0; // Останавливаем время
        }
        else if (other.CompareTag("Wall"))
        {
            Debug.Log("Game Over! You hit the wall!");
            isGameOver = true;
            Object.FindFirstObjectByType<GameManager>().GameOver(Object.FindFirstObjectByType<ScoreManager>().GetScore());
            Time.timeScale = 0; // Останавливаем время
        }
    }

    public void IncreaseSpeed()
    {
        speed += 0.1f; // Увеличиваем скорость после каждого блока
    }

}
