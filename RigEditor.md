# Introduction #
This is an editor for the _RIG type files.  It allows for an easier way to modify the skeletal structure of an object, and automates common bone operations and math calculations._

Note: The current version does not require any 3rd party libraries from RADGames as the previous versions did as the format has been changed.


# Features #
![http://s3pi-wrappers.googlecode.com/svn/wiki/RigEditor/main_screen.png](http://s3pi-wrappers.googlecode.com/svn/wiki/RigEditor/main_screen.png)

## Main Editor ##
The Name, Position, Orientation, and Scale of the selected bone can be modified on the right.  The name hash is read only and is recalculated when the name changes.  The "Rotation" is done as an Euler rotation that gets converted in the background to a Quaternion as a storage requirement.
## Context Menu ##
Right-clicking a bone will give you an array of actions you can execute on the selected bone.

### Add ###
This will add a bone with a given name as a child bone to the selected bone.
### Clone ###
This will make a copy of the selected bone and attach it as a sibling of the selected bone.

### Clone Hierarchy ###
This will clone the selected bone and all of its descendants attaching it as a sibling to the selected bone.
### Remove ###
This is a "safe" removal of the bone.  Descendants will be shifted up one level so that immediate children are adopted by grandparent and the hierarchy otherwise unaffected.
### Remove Hierarchy ###
This is a less safe way to remove a bone.  All descendants will be removed as well.  Use this option with caution.
### Set Parent ###
This reparents a bone to any other bone(you will be prompted to choose which one) in the rig(excluding itself, and any of its descendants)

### Unparent ###
This detaches the bone from its parent, placing it at the root level.  You should rarely if ever need to use it.

## Replace in Names ##
This action performs a Find And Replace on the selected bone, and ALL of its descendants.  This can be used in conjunction with Clone Hierarchy for example to replace "L_" left prefixed bones with "R_"
### Prefix Hierarchy ###
This will add a prefix to the name of the selected bone and ALL of its descendants.

### Suffix Hierarchy ###
This will add a suffix to the name of the selected bone and ALL of its descendants.

## Matrix Info ##
There is a button on the main screen to calculate matrices for all of the bones.

![http://s3pi-wrappers.googlecode.com/svn/wiki/RigEditor/matrix_info.png](http://s3pi-wrappers.googlecode.com/svn/wiki/RigEditor/matrix_info.png)

This will bake the relative transformations of the bones into formats that can be entered into the Skin Controllers(inverse transforms) and the Slots(absolute transforms)