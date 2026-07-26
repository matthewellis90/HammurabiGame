📘 HammurabiGame
A modernised C# WinForms recreation of the classic Hammurabi resource‑management game — originally built as a university project while learning procedural programming.

🏛️ About the Hammurabi Game
The Hammurabi game (sometimes called Hamurabi, Hammurapi, or The Sumer Game) is one of the earliest examples of a computer strategy game. It first appeared in the late 1960s and early 1970s on mainframe systems like the DEC PDP‑8 and PDP‑10.

The premise is simple but surprisingly deep:

You are Hammurabi, ruler of ancient Sumer.

Each year, you decide how to allocate resources:

how many acres of land to buy or sell,

how much grain to feed your people,

how much grain to plant for next year’s harvest.

Random events (plagues, crop yields, rat infestations) affect your success.

Your goal is to keep your population alive and grow your kingdom.

Despite its simplicity, the game is historically significant — it taught early programmers about input handling, branching logic, randomness, and simulation design.

🎓 About This Project
This version of Hammurabi was originally created as part of a university assignment while learning procedural programming in C#. The goal was to:

implement the classic Hammurabi ruleset,

build a simple UI using Windows Forms,

practice control flow, functions, and basic state management,

and understand how to structure a small simulation game.

Years later, the project has been revived, repaired, and modernised — fixing long‑standing build issues, cleaning the WinForms designer structure, and restoring the game to a working state.

🖥️ Features
Classic Hammurabi gameplay loop

WinForms UI with numeric inputs and charts

Year‑by‑year simulation

Grain, land, and population management

Basic statistics visualisation

🔧 Tech Stack
Language: C#

Framework: .NET Framework 4.8

UI: Windows Forms

Charts: System.Windows.Forms.DataVisualization

IDE: Visual Studio

📂 Project Status
The project now builds and runs cleanly after resolving:

corrupted designer files

mismatched .resx resources

ghost auto‑generated classes

broken .csproj metadata

The game is playable, but still lacks some UI polish and additional features. Future improvements may include:

better charting

improved layout

more detailed event messages

expanded gameplay logic

saving/loading game state

🚀 Getting Started
Clone the repository:

bash
git clone https://github.com/matthewellis90/HammurabiGame.git
Open the solution in Visual Studio and run the WinForms project.

📜 License
You can choose a license later — MIT is typical for small educational projects.

🙌 Acknowledgements
Inspired by the original Hamurabi game created by Richard Merrill and popularised through early BASIC programming examples.
