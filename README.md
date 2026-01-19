# 2048 Clone (Unity)

This project is a Unity (C#) implementation of the classic 2048 sliding tile puzzle game.
It was built as a learning project to understand grid-based game logic, state management,
and Unity-oriented architecture.

## About the Game
2048 is a single-player puzzle game played on a 4x4 grid. The player slides numbered tiles
in four directions. When two tiles with the same value collide, they merge into one,
and the goal is to reach the 2048 tile.

## Core Design Approach
Instead of representing the board using a traditional 2D array, the grid is modeled
using Unity GameObjects and components:

- Each grid position is represented by a `TileCell`
- Rows are grouped using `TileRow`
- The board structure is derived from the scene hierarchy
- Tile movement and merging logic operates by querying neighboring cells

This approach keeps the implementation Unity-native, editor-driven, and visually debuggable.

## Features
- 4x4 grid-based board defined through scene hierarchy
- Tile movement and merge logic based on neighboring cell checks
- Score tracking
- Win and game-over detection
- Keyboard input controls
- Tile visuals driven by ScriptableObjects

## Project Structure Overview
- `TileCell`  -  Represents a single grid cell and tracks whether it is occupied by a tile.

- `TileRow`  -  Groups cells horizontally and helps define board layout.

- `TileGrid`  -  Builds the logical grid from the scene hierarchy and determines board dimensions.

- `Tile`  -  Represents an individual numbered tile and handles its visual state.

- `TileState` (ScriptableObject)  -  Stores tile values, colors, and appearance data separately from logic.

- `TileBoard`  -  Handles movement resolution, merge rules, and turn-based board updates.

- `GameManager`  -  Manages overall game flow, score, spawning, and game state.

## Tech Stack
- Unity Engine
- C#
- Microsoft Visual Studio
- ScriptableObjects for data-driven visuals
- Git and GitHub for version control

## What I Learned
- Designing grid-based game logic without relying on 2D arrays
- Using scene hierarchy as a source of game state
- Implementing tile movement and merge rules safely
- Separating game logic, visuals, and data using Unity components
- Managing a clean Unity project structure with proper `.gitignore` usage

## Controls
- Arrow Keys / WASD: Move tiles

## Screenshots
<img width="1900" height="932" alt="image" src="https://github.com/user-attachments/assets/2e4a6f11-cac0-40f7-8909-55c3d0be0992" />
<img width="1919" height="928" alt="image" src="https://github.com/user-attachments/assets/fbd82969-2843-4412-897e-81d9fce62fc5" />
<img width="1919" height="674" alt="image" src="https://github.com/user-attachments/assets/d7ced2b8-d1de-45ae-9926-93c42a95fc8e" />

## Build
A playable Windows build is available in the Releases section of this repository.


## Notes
This project is a clone created purely for educational purposes to practice game
development concepts and Unity architecture.
