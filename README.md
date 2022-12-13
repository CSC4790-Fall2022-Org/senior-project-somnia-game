# Somnia: A College Life Simulator
Repo for CSC 4790 Senior Project Somnia. Experience the wonders of time, energy, and sleep management during college life.

[CSC 4790 Final Release](https://github.com/CSC4790-Fall2022-Org/senior-project-somnia-game/releases/tag/final-release)

## Abstract
Somnia shows the importance of sleep and time management by putting the player in the shoes of a new college student. Players are free to choose what they do, but must manage their stats and time, mirroring real life responsibility. Stats show how certain actions affect the players and affect the difficulty of the night section, which simulates sleep and will affect the next day. This illustrates how sleep affects a student's daily life. 

## Acknowledgements
Huge thanks to Runia Dev for their Dialogue Editor.
See [the wiki](https://github.com/CSC4790-Fall2022-Org/senior-project-somnia-game/wiki) for full credits.

## Built With
Unity Engine and C#

## Getting Started
### Prerequisites
Download [Unity Hub](https://unity3d.com/get-unity/download), and on the left, go to `Installs > Install Editor` in the top-right. The recommended LTS version should work, but if you would like to use the editor version we used, go [here](https://unity3d.com/get-unity/download/archive), scroll down, and install version **2021.3.9f1**.

### Installation
1. Clone the repo.
2. Open Unity Hub and go to Projects on the left.
3. Select the **Open** button in the top-right.
4. Navigate to and select the project directory `senior-project-somnia-game`.
5. Open the project and you're set!

### Contributing
1. Everything is mostly organized between Daytime and Nighttime.
2. Scripts (code) are in `Assets/Scripts`. You can edit them in your preferred editor, however Visual Studio is the most compatible with Unity.
3. Scenes (graphically editable in Scene view) are in `Assets/Scenes`. 
4. To edit dialogue, you have to have the DialogueEditor view open. Go to Window > DialogueEditor and place it where you like. Then make sure you have a NPCConversation object (i.e., an object with the NPC Conversation script attached to it) selected. For more details, check the DialogueEditor documentation in `Assets/DialogueEditor/DialogueEditorDocumentation.pdf` [here](https://github.com/CSC4790-Fall2022-Org/senior-project-somnia-game/blob/dev/Assets/DialogueEditor/DialogueEditorDocumentation.pdf).
5. Use `Build Settings` in the top menu to add scenes to build. This is also used for scene transitions. The game can be built for OSX and Windows. You can try other platforms, but we have not tested them.
6. You can preview how the game looks with the Game view.

### Execution
Ensure that you are on the `Menu.unity` scene before pressing play. If you are not on this scene, change to it by pressing `File -> Open Scene`, and navigate to `Assets/Scenes`. Click on `Menu.unity`, then just press the play button at the top!
