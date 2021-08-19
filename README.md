# GDataTool
General editor for Monster Hunter G (PS2).

## Usage
You need an unpacked copy of sub_main.bin from MHG.

To obtain it:
* Open an ISO copy of MHG, copy AFS_DATA.AFS into a folder of your choosing.
* Use AFS Packer https://github.com/MaikelChan/AFSPacker to unpack the file (afspacker.exe -e afs_data.afs gdata gfiles.txt).
* Go into the new folder and search for sub_main.bin, copy it into your working folder.
* Use https://github.com/viciousShadow/mhtools python script to unpack.
* Install python 2.6 and use the command "pip install pygobject" and then "pip install pygtk"
* After this, double click on the python script to open it.
* Open the .unpacked file with this tool.

## To-Do

* Implement Gunner Weapons.
* Implement Armor Pieces.
* Implement Items.
* Implement Crafting Editing.
* Implement Shop List Editing.
* Introduce better calculation of offsets.
