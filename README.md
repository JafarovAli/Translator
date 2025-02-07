# English to Azerbaijani Translation Game

## Overview
This is a simple console-based English-to-Azerbaijani translation game written in C#. The program loads a dictionary from a text file and randomly selects an English word for the user to translate. The user inputs their answer, and the program checks if the translation is correct.

## Features
- Loads word pairs from a dictionary file (`dictionary.txt`).
- Randomly selects an English word for the user to translate.
- Checks the user's translation and provides feedback.
- Handles errors related to file reading and dictionary parsing.

## Requirements
- .NET installed on your system.
- A text file named `dictionary.txt` containing word pairs in the format:
  ```
  hello-salam
  apple-alma
  house-ev
  ```

## Installation & Usage
1. Clone or download this repository.
2. Ensure you have a `dictionary.txt` file with word pairs.
3. Open a terminal or command prompt and navigate to the project directory.
4. Compile and run the program using:
   ```
   dotnet run
   ```
5. Follow the on-screen instructions to play the game.

## How It Works
1. The program reads the `dictionary.txt` file and loads word pairs into a dictionary.
2. It randomly selects an English word and prompts the user to enter its Azerbaijani translation.
3. The user types in their answer.
4. The program checks the answer and provides feedback (correct or incorrect).
5. If the dictionary is empty or the file cannot be loaded, an error message is displayed.

## Error Handling
- If `dictionary.txt` is missing or unreadable, the program will display an error message.
- If the file format is incorrect (e.g., missing `-` separator), the entry will be ignored.

## License
This project is open-source and free to use. Feel free to modify and improve it!

## Author
Developed by [Ali Jafarov]

