# Flappy Crow

A 2D infinite runner game built with Unity where players control a crow to avoid obstacles. This project demonstrates basic 2D game mechanics, physics interactions, and the Unity Input System.

## Features

- **Infinite Runner Gameplay**: The game continues indefinitely until the player hits an obstacle.
- **Touch Controls**: Simple tap-to-jump mechanics optimized for mobile and touch screens.
- **Dynamic Obstacles**: Pipes spawn at varying heights to challenge the player.
- **Time-Based Scoring**: Score increases the longer you survive.
- **Game Loop**: Includes a Main Menu, Gameplay loop, and Game Over/Restart functionality.

## Tech Stack

- **Engine**: Unity 6 (6000.0.64f1)
- **Language**: C#
- **Input**: Unity Input System (Touch/Click)

## Installation

1.  **Clone the Repository**:
    ```bash
    git clone <repository-url>
    ```
2.  **Open in Unity**:
    - Launch Unity Hub.
    - Click **Add** and select the cloned `crowgame` folder.
    - Open the project (ensure you have Unity 6 or a compatible version installed).
3.  **Load the Scene**:
    - Navigate to `Assets/Scenes/`.
    - Open `Game.unity` to play the main game.

## How to Play

1.  Hit the **Play** button in the Unity Editor or build and run the game.
2.  **Controls**:
    - **Tap / Click**: Flap wings (Jump).
3.  **Objective**:
    - Keep the crow afloat.
    - Avoid colliding with the pipes or the ground.
    - Survive as long as possible to achieve a high score.

## File Structure

- **Scripts** (`Assets/Scripts/`):
    - `Birdmovemnt.cs`: Handles player physics and input.
    - `pipespawner.cs`: Manages obstacle generation.
    - `Scoremanger.cs`: Tracks and displays the score.
    - `Menumanager.cs`: Handles UI and scene transitions.
- **Scenes** (`Assets/Scenes/`):
    - `Game.unity`: The main gameplay scene.
    - `Logo.unity`: Splash screen/Logo scene.
    - `LoadingScene.unity`: Scene transition handler.

## License

This project is for educational purposes.
