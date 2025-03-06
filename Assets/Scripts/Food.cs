using UnityEngine;

public class Food : MonoBehaviour
{
    public Vector3 fieldSize = new Vector3(10, 0.5f, 10); // Размер поля

    void Start()
    {
        RespawnFood();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверяем, что еда съедена змейкой
        {
            SnakeBody snake = Object.FindFirstObjectByType<SnakeBody>(); // Используем новый метод
            if (snake != null)
            {
                snake.Grow(); // Добавляем сегмент тела

                ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();
                if (scoreManager != null)
                {
                    scoreManager.IncreaseScore();
                }
            }
            RespawnFood(); // Перемещаем еду в случайное место
        }
    }

    void RespawnFood()
    {
        float x = Random.Range(-fieldSize.x / 2, fieldSize.x / 2);
        float z = Random.Range(-fieldSize.z / 2, fieldSize.z / 2);
        transform.position = new Vector3(x, fieldSize.y, z);
    }
}
