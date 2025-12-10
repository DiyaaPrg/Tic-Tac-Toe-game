🎮 Tic Tac Toe – Windows Forms Game

A simple but polished Tic Tac Toe game built using C# .NET Windows Forms.
This project focuses on practicing event handling, UI design, drawing graphics, and managing game logic in WinForms.

📸 Preview

(Add screenshots of your game here)
Example:

![Tic Tac Toe Screenshot](images/pic1.png)
![Tic Tac Toe Screenshot](images/pic2.png)
![Tic Tac Toe Screenshot](images/pic3.png)


✨ Features

✔️ Two-player (X vs O) gameplay
✔️ Automatically detects winners (rows, columns, diagonals)
✔️ Highlights the winning line
✔️ Validates moves (prevents changing a cell already played)
✔️ Displays current player's turn
✔️ Shows game result (Winner / Draw)
✔️ "Restart Game" button to reset everything
✔️ Clean and organized code using events and helper functions
✔️ Uses resources for X and O icons

🧠 How It Works
Game Logic

Each PictureBox represents a cell (1–9).

The Tag property stores either:

'X' — Player X

'O' — Player O

'1'..'9' (initial state – unique ID for each box)

When the user clicks a picture box:

The game checks if the cell is free.

Places X or O.

Checks for winner depending on the last move (optimized win checking).

Switches turns.

Winning Detection

To reduce unnecessary checks, the game only verifies the lines related to the last move (cell 1–9).
Example:

Cell 1 → check Row1, Column1, Diagonal1

Cell 5 → check all lines (center position)

This makes the game more efficient and cleaner.

Visual Design

The grid lines are drawn inside Form1_Paint using Graphics.DrawLine().

Winning cells change their background to yellow using ColorWinningSymbols().

🛠️ Technologies Used

C# .NET

Windows Forms (WinForms)

GDI+ Graphics (for drawing the grid)

Resource files (.resx) for images

📂 Project Structure
TicTacToe/
│
├── Properties/
├── Resources/
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── TicTacToe.csproj
└── README.md  <-- you are here



🧑‍💻 Author

Diyaa Eddine Baamara

GitHub: 
DiyaaPrg
Email: dhiabaamara@gmail.com
