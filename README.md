# 🐍 3D Snake Game 🎮  
<p align="center">
  <img src="README_assets/preview.png" alt="3D Snake" width="60%">
</p>

<p align="center">
   <img src="https://img.shields.io/badge/Engine-Unity-black?logo=unity" alt="Engine">
   <img src="https://img.shields.io/badge/Language-C%23-purple?logo=csharp" alt="Language">
   <img src="https://img.shields.io/badge/Platform-WebGL-blue?logo=google-chrome" alt="Platform">
   <img src="https://img.shields.io/badge/Platform-Windows%20|%20Mac%20|%20Linux-green?logo=windows" alt="Platform">
   <img src="https://img.shields.io/badge/Status-In%20Development-orange?logo=github" alt="Status">
   <img src="https://img.shields.io/badge/License-MIT-red?logo=open-source-initiative" alt="License">
   <img src="https://img.shields.io/badge/Version-1.0-brightgreen" alt="Version">
</p>


📌 **Описание:**  
Этот проект — реализация классической игры «Змейка» в 3D, разработанный в рамках дисциплины **«Программная инженерия»**.  
Цель — собрать как можно больше яблок 🍏, чтобы увеличить длину змейки и скорость передвижения.

---

## 🔥 Основные механики:

- **Движение** 🚀  
  - Змейка движется **автономно вперёд**, а игрок может только **управлять поворотами** (A/D или стрелки влево/вправо ⬅️➡️).
- **Система роста** 📈  
  - Чем больше яблок съедает змейка, тем **длиннее её хвост** и **быстрее скорость**.
- **Мини-карта & Интерфейс** 🗺️  
  - В правом верхнем углу есть **вид сверху**, где видно змейку и расположение яблок.
  - **Счётчик очков** в левом верхнем углу показывает **количество собранных яблок**.
- **Текстуры & Визуализация** 🎨  
  - Используются **детализированные текстуры** для игрового поля, стен и неба.

---

## ⚙️ Используемые скрипты:

| Скрипт            | Описание |
|------------------|-------------------------------------------------|
| **Food.cs**      | Управляет появлением и исчезновением еды 🍏. |
| **GameManager.cs** | Главный контроллер игры 🕹️, отслеживает состояние. |
| **ScoreManager.cs** | Подсчёт очков и отображение на экране 🏆. |
| **SnakeBody.cs**   | Управление ростом хвоста змейки 🐍. |
| **SnakeHead.cs**   | Логика управления головой змейки и поворотами 🔄. |

---

## 🎮 Управление:

| Действие        | Клавиша |
|---------------|----------|
| Поворот влево  | `A` / `⬅️` |
| Поворот вправо | `D` / `➡️` |

🚀 **Змейка двигается вперёд автоматически!**  

---

## 🛠️ Как запустить:

1. **Склонировать репозиторий**  
   ```sh
   git clone https://github.com/Tatarenok/3DSnake.git
   ```
2. Открыть проект в Unity (версия 6000.0.35f1).
3. Запустить сцену в Unity Editor или собрать билд.

## 📸 Игра:

![Геймплей](README_assets/vid1.gif)
![Тестировка](README_assets/gameplay2.gif)

💡 Автор: [Tatarenok](https://github.com/Tatarenok)

📌 Проект на GitHub: Snake3D

📢 P.S. Если понравился проект — поставь ⭐️!
