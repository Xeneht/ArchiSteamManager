![ArchiSteamManagerLarge](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/bc6261f5-97a5-440b-a759-353f8f2d87b8)

<hr style="border-radius: 2%; margin-top: 60px; margin-bottom: 60px;" noshade="" size="20" width="100%">

<div align="center">

[![Developer](https://img.shields.io/badge/Developer-Xeneht-red.svg?style=flat&logo=github)](https://github.com/Xeneht)
[![Version](https://img.shields.io/badge/Version-1.0-blue.svg?style=flat&logo=github)](https://github.com/Xeneht/ArchiSteamManager/releases/tag/Download)

</div>

# Setup
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/d7acf5c4-1799-473a-a01f-84a0b4905a1e)
- Select ArchiSteamFarm folder (contains the ArchiSteamFarm.exe)

If the folder does not contain a "config" folder try starting ArchiSteamFarm.exe

# Features
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/39986628-4e5e-4965-ba85-2b31d990f621)

### Import Account List
- Select account list user:pass (one per line)

A json file will be created for each account with the defined settings

### Export Account List
- Select the directory where the file with the exported accounts will be saved
- In case of duplicate accounts, these will be skipped, each account will be exported only once

A text file will be created with all the accounts exported from all json on config path

### Remove Duplicates
- All duplicated accounts on json files will be removed (Only the json files with the file name prefix defined on settings)
- All files will be renamed to have a complete list (If we have accounts from Bot1 to Bot10 and the 3, 5 and 7 are duplicated, the other files will be renamed so that there are no missing numbers, we will finally have from Bot1 to Bot7 as 3 accounts were duplicated)

# Settings
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/19a475a0-d2e6-4ec2-987c-1958bd956b9b)

### ArchiSteamFarm Path
- You can change the folder path manually, but in any case, if the folder is not in place when you start the application, it will ask you to do the setup again

### Games List
- This is the list of games that will be at "GamesPlayedWhileIdle"
- Format (gameid, gameid, gameid)

You can find the gameIds at https://steamdb.info/ searching the game, on the table you will find the App ID

### Files Name
- This is the prefix for the files created when importing accounts, when deleting duplicates, the program will only take into account files with this name

### Reset Config
- Config file will be reseted and you will be asked to do the setup again

⚠️ A confirmation alert will be displayed

### Open Logs
- Logs file will be opened (Path: Disk:\Users\(Username)\AppData\Roaming\ArchiSteamManager\logs.txt)
- Log file contains imports, exports, removed duplicates, renamed files and error logs

### Clear Logs
- Logs file will be deleted

⚠️ A confirmation alert will be displayed

### Remove All Accounts
- All .json and .db files will be deleted from the ArchiSteamFarm config path (These files contain steam accounts and tokens)
- Files Name defined will be ignored, this will remove all the accounts

⚠️ A confirmation alert will be displayed
