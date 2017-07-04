# PocketRogueDropEditor
A tool written in C# that lets me create drop table definitions for NPCs in my PocketRogue game. 
Exports the drops to JSON format for easy parsing in game libraries.

# Usage
This tool allows the editing of drop tables for an NPC and the editing of drops within that table. 
Drops are in a many-to-one relationship with drop tables.

A drop consists of an item ID, the amount to drop and the drop rate. 
The drop rate is defined as 1/dropRate so a value of 100 would indicate a 1/100 chance.
Currently this tool does not support defining ranges of amounts (e.g. 3-7 of an item).
Drop tables are defined as containing many drops and need an NPC ID and an NPC name.
You can also load in an item definition file for auto-complete when creating new drops.
This will only work for a definition file that matches the patterns found in ItemDefinition.cs.
An example of such a file can be found in either of my PocketRogue repositories.
