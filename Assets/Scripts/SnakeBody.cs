using UnityEngine;
using System.Collections.Generic;

public class SnakeBody : MonoBehaviour
{
    public Transform head; // Ссылка на голову
    public GameObject bodyPrefab; // Префаб сегмента тела
    private List<Vector3> positions = new List<Vector3>(); // История позиций

    void FixedUpdate()
    {
        if (positions.Count == 0)
            positions.Add(head.position);

        positions.Insert(0, head.position); // Запоминаем текущую позицию головы

        for (int i = 0; i < transform.childCount; i++)
        {
            int index = Mathf.Clamp(i * 5, 0, positions.Count - 1);
            transform.GetChild(i).position = positions[index]; // Двигаем тело точно за головой
        }

        // Ограничиваем длину списка позиций
        if (positions.Count > transform.childCount * 5)
            positions.RemoveAt(positions.Count - 1);
    }

    // Функция для роста змейки
    public void Grow()
    {
        Vector3 spawnPosition;

        // Если в списке позиций есть достаточное количество точек, берем дальнюю позицию
        if (positions.Count > 10)
        {
            spawnPosition = positions[positions.Count - 10]; // Берем позицию на N шагов назад
        }
        else
        {
            spawnPosition = head.position - head.forward * 2f; // Если позиций мало, отодвигаем по направлению движения
        }

        // Создаем новый сегмент
        GameObject newSegment = Instantiate(bodyPrefab, spawnPosition, Quaternion.identity);
        newSegment.transform.SetParent(this.transform);

        // Проверяем, сколько сегментов уже есть в теле
        int bodyCount = transform.childCount;

        // Первые 5 сегментов НЕ имеют тега "Body"
        if (bodyCount > 5)
        {
            newSegment.tag = "Body"; // Только дальние сегменты станут препятствием

            // Отключаем триггер на 3 секунды
            Collider segmentCollider = newSegment.GetComponent<Collider>();
            if (segmentCollider != null)
            {
                segmentCollider.isTrigger = false; // Выключаем триггер
                Invoke(nameof(EnableTrigger), 3f); // Включаем триггер через 3 секунды
            }
        }
    }

    // Функция для включения триггера у сегмента
    void EnableTrigger()
    {
        Collider[] allSegments = GetComponentsInChildren<Collider>();
        if (allSegments.Length > 0)
        {
            Collider lastSegment = allSegments[allSegments.Length - 1]; // Последний сегмент
            lastSegment.isTrigger = true; // Включаем триггер
        }
    }
}
