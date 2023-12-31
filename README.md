![ArchiSteamManagerLarge](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/d9e03341-8285-495a-aaba-86653ea1d787)

<hr style="border-radius: 2%; margin-top: 60px; margin-bottom: 60px;" noshade="" size="20" width="100%">

<div align="center">

[![Developer](https://img.shields.io/badge/Developer-Xeneht-red.svg?style=flat&logo=github)](https://github.com/Xeneht)
[![Version](https://img.shields.io/badge/Version-1.2.0-blue.svg?style=flat&logo=github)](https://github.com/Xeneht/ArchiSteamManager/releases/tag/Download)

</div>

# 🔧 Setup
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/c7cfc63b-f8bd-4548-8395-8cc019becb03)

- Select ArchiSteamFarm folder (contains the ArchiSteamFarm.exe)

If the folder does not contain a "config" folder try starting ArchiSteamFarm.exe

# 📄 Features
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/370bf2ca-e596-48f8-925e-7c44ddec521d)

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

# ⚙️ Settings
![image](https://github.com/Xeneht/ArchiSteamManager/assets/99096857/f503dd7d-213a-4d74-a8bf-e5eccad43c0e)

### ArchiSteamFarm Path
- You can change the folder path manually, but in any case, if the folder is not in place when you start the application, it will ask you to do the setup again

### Games List
- This is the list of games that will be at "GamesPlayedWhileIdle"
- Format (gameid, gameid, gameid)

You can find the gameIds at https://steamdb.info/ searching the game, on the table you will find the App ID

### Files Name
- This is the prefix for the files created when importing accounts, when deleting duplicates, the program will only take into account files with this name

### Reset Config
⚠️ A confirmation alert will be displayed
- Config file will be reseted and you will be asked to do the setup again

### Open Logs
- Logs file will be opened (Path: Disk:\Users\(Username)\AppData\Roaming\ArchiSteamManager\logs.txt)
- Log file contains imports, exports, removed duplicates, renamed files and error logs

### Clear Logs
⚠️ A confirmation alert will be displayed
- Logs file will be deleted

### Remove All Accounts
⚠️ A confirmation alert will be displayed
- All .json and .db files will be deleted from the ArchiSteamFarm config path (These files contain steam accounts and tokens)
- Files Name defined will be ignored, this will remove all the accounts

# 📝 License

1. Personal use permitted.
2. Modification of code allowed.
3. Code must remain open source.
4. Creator credit required in all distributions and modifications.
5. Commercial use not allowed.

# 📃 Changelog

## V1.2.0

**General**

- `Added` - Logging with timestamps.
- `Improved` - Error handling during initial config file checks.

**Logging**

- `Added` - Timestamps to log entries.
- `Improved` - Increased logs quantity.
- `Improved` - Log messages and errors.

**Import Accounts**

- `Added` - Progress bar while importing.
- `Added` - Implemented background worker for account importing.
- `Improved` - Error handling.
- `Improved` - Buttons disabled during import, re-enabled after completion.
- `Improved` - Shitty code was doing a lot of definitions and calling functions for each account you imported instead of doing it one time only.

**Remove Duplicates**

- `Added` - Progress bar during duplicate removal.
- `Added` - Implemented background worker for duplicate removal.
- `Improved` - New duplication removal method (Now exports all accounts, removes duplicates, and re-imports them instead of comparing files to remove duplicates and changing file names)
- `Improved` - Increased speed for large numbers of files (5x faster processing 1000 account files)
- `Improved` - Buttons disabled during process, re-enabled after completion.

**Config**
- `Added` - Numeration format selection dropdown (FileName1/01/001/0001/00001).
- `Added` - Update format dropdown based on filename configuration.
