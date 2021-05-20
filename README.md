# Unity Utilities

Utilities to improve the C# experience in Unity: ranging from more capabilities to shorter code length.

For now, to use this library, you need to copy the repo (or download it) and build a .dll file in Visual Studio,
Jetbrains Rider or any .NET IDE, to then add it to your Unity project! Alternatively, you can also copy all the scripts
in your project :) Don't forget to add the `UnityUtilities` namespace!

## Todo

| Cleanup and refactor | Done? |
| :--- | :---: |
| Separate into files depending on what it extends | ✔ | 
| Group similar and overloaded functions together  | ✔ |
  
- Add more :D

# Extensions

## Numerals

- `Round` > Rounds float and returns float; number of decimals can be specified.
- `RoundToInt` > Rounds float and returns int.
- `Abs` > Returns the absolute value (of ints and floats).
- `Clamp` > Clamps float or int to the supplied range.
- `Map` > Maps a float from the supplied range to the supplied range (for floats and ints).

## GameObject

- `GoUp` > Smoothly translates the gameobject (or transform) up at the desired speed (float).
- `GoDown` > Smoothly translates the gameobject (or transform) down at the desired speed (float).
- `GoLeft` > Smoothly translates the gameobject (or transform) left at the desired speed (float).
- `GoRight` > Smoothly translates the gameobject (or transform) right at the desired speed (float).
- `GoForward` > Smoothly translates the gameobject (or transform) forward at the desired speed (float).
- `GoBackward` > Smoothly translates the gameobject (or transform) backward at the desired speed (float).
- `FollowMouse2D` > Smoothly makes the Rigidbody2D follow the mouse position at the desired speeds (float, float);
- `FollowObject2D` > Smoothly makes the Rigidbody2D follow the specified object (or transform) at the desired speeds (float, float);

## Vectors

- `Round` > Rounds Vector2, Vector3 and returns a rounded vector with the specified number of decimals.
- `RoundToInt` > Rounds Vector2, Vector3 and returns Vector2Int.
- `Clamp` > Clamps the components of the Vector3 between supplied values.
- `VectorFromAngle` > Returns the corresponding vector to the given angle (in degrees or radians).
- `RotateByAngle` > Rotates the Vector2 by the given angle (in degress or radians). This method assumes +X axis is 0
  degrees/radians.
- `AngleFromVector` > Returns the positive angle in degrees (or radians) of given Vector2. This method assumes +X axis is 0
  degrees/radians.
- `TransformTo2DVector3` > Transforms Vector2 into Vector3 respecting Unity's coordinate system (so x = x, y = 0, z = y).
- `ChopTo2DVector3` > Takes and returns a Vector3 respecting Unity's coordinate system (so x = x, y = 0 (or specified), z = y).
- `ToVector2` > Transforms a 2-big float array to a Vector 2.
- `GeoDistanceTo` > Calculates distance between two coordinates.

# Code Shorteners

- `Print` > Cleaner way of Debug.Log() with message type support
- `DelayAction` > Delays supplied action by specified number of seconds (float).
- `Destroy` > More elegant way of writing Destroy(gameObject).
- `DestroyImmediate` > More elegant way of writing DestroyImmediate(gameObject).

## Log

### Changelog (19-05-2021)

- Removed `ref` keyword (accident, sorry!)
- Changed all namespaces to `UnityUtilities`
- Added `ToVector2` to transform 2-big float arrays into a vector 2
- Added `GeoDistanceTo` to calculate distance between two geocoordinates

### Changelog (26-04-2021)

- Removed `ValueType` method
- Changed all angle related methods to a single one for each use case, i.e. you now have to specify what unit of measure you are using :)
- All of the `GoUp`, `GoDown`, etc. methods can now be directly used for Transforms as well
- Separated each extension-related methods in their respective files (Numerals, GameObject, Vector, Unity (= Misc.))
- Removed `double` methods as it's rarely used in Unity

### Changelog (25-04-2021)

Will probably remove the ValueType function as it can be used with a variety of things and can therefore introduce bugs 😅

- Added `DelayAction`
- Added `DestroyImmediate`
- Added `Clamp` (for vectors and floats)
- Added `TransformTo2DVector3`
- Added `ChopTo2DVector3`
- Added `Map`
- Moved all `CsExtensions.cs` functions into UnityExtensions as this is a Unity only extension "pack"
- `Round` now returns Vector3Int and Vector2Int when paramaterless
- Simplified use `FollowMouse2D` and `FollowObject2D`
- Replaced specific value types for `var`

### Changelog (1-01-2021)

- Added `RoundToInt`
- Added `GoUp`
- Added `GoDown`
- Added `GoLeft`
- Added `GoRight`
- Added `GoForward`
- Added `GoBackward`
- Added `FollowMouse`
- Added `FollowObject2D`
- Expanded `Print`
- Cleaned up README

### Changelog (1-12-2020 // ~8:50)

- Changed solution and project name
- Added some instructions to the README =D
