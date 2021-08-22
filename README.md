# GDataTool
General editor for Monster Hunter G (PS2).

G Data Tool can currently edit both blademaster and gunner weapons.
G Lobby Tool can currently edit town/village NPC dialog.

## Download
Head over to https://github.com/YukiHaze/GDataTool/releases for the latest release build.

## Usage
You need unpacked copies of sub_main.bin and lobby.bin from MHG.

To obtain it:
* Open an ISO copy of MHG, copy AFS_DATA.AFS into a folder of your choosing.
* Use AFS Packer https://github.com/MaikelChan/AFSPacker to unpack the file (afspacker.exe -e afs_data.afs gdata gfiles.txt).
* Go into the new folder and search for sub_main.bin and lobby.bin, copy them into your working folder.
* Use https://github.com/viciousShadow/mhtools python script to unpack.
* Install python 2.6 and use the command "pip install pygobject" and then "pip install pygtk"
* After this, double click on the python script to open it, click unpack and select sub_main.bin
* Once it's done, click unpack again and select lobby.bin
* Open the new .unpacked file with GDataTool.

## To-Do

* Implement Armor Pieces.
* Implement Items.
* Implement Crafting Editing.
* Implement Shop List Editing.
* Introduce better calculation of offsets.
