# Unity Utilities

Utilities to improve the C# experience in Unity: ranging from more capabilities to shorter code length.

For now, to use this library, you need to copy the repo (or download it) and build a .dll file in Visual Studio,
Jetbrains Rider or any .NET IDE, to then add it to your Unity project! Alternatively, you can also copy all the scripts
in your project :) Don't forget to add the `Utilities` namespace!

Cleaning and refactoring needs to be done as the number of extension methods are growing!

## Todo

- Cleanup and refactor
  - Separate into files depending on what it extends
  - Group similar and overloaded functions together
  
- Add more :D

# Extensions

## Numerals : takes any type of number (float, int, double) and returns it in the same type

- `Abs` > Returns the absolute value.

## Float

- `Round` > Rounds float and returns float; number of decimals can be specified.
- `RoundToInt` > Rounds float and returns int.
- `Clamp` > Clamps float to the supplied range.
- `Map` > Maps a float from the supplied range to the supplied range.

## Double

- `RoundToInt` > Rounds double and returns int.

## GameObject

- `GoUp` > Smoothly translates the gameobject up at the desired speed (float).
- `GoDown` > Smoothly translates the gameobject down at the desired speed (float).
- `GoLeft` > Smoothly translates the gameobject left at the desired speed (float).
- `GoRight` > Smoothly translates the gameobject right at the desired speed (float).
- `GoForward` > Smoothly translates the gameobject forward at the desired speed (float).
- `GoBackward` > Smoothly translates the gameobject backward at the desired speed (float).
- `FollowMouse2D` > Smoothly makes the Rigidbody2D follow the mouse position at the desired speeds (float, float);
- `FollowObject2D` > Smoothly makes the Rigidbody2D follow the specified object (or transform) at the desired speeds (float, float);

## Vectors

- `VectorFromAngleRad` > Returns the corresponding vector to the given angle (in radians).
- `VectorFromAngleDeg` > Returns the corresponding vector to the given angle (in degrees).
- `RotateByAngleRad` > Rotates the Vector2 by the given angle (in radians).
- `RotateByAngleDeg` > Rotates the Vector2 by the given angle (in degrees).
- `AngleFromVectorRad` > Returns the positive angle in degrees of given Vector2. This method assumes +X axis is 0
  degrees.
- `AngleFromVectorDeg` > Returns the positive angle in radians of given Vector2. This method assumes +X axis is 0
  degrees.
- `Round` > Rounds Vector2, Vector3 and can return Vector2Int when parameterless.
- `Clamp` > Clamps the components of the Vector3 between supplied values
- `TransformTo2DVector3` > Transforms Vector2 into Vector3 respecting Unity's coordinate system (so x = x, y = 0, z = y).
- `ChopTo2DVector3` > Takes and returns a Vector3 respecting Unity's coordinate system (so x = x, y = 0 (or specified), z = y).

# Code Shorteners

- `Print` > Cleaner way of Debug.Log() with message type support
- `DelayAction` > Delays supplied action by specified number of seconds (float).
- `Destroy` > More elegant way of writing Destroy(gameObject).
- `DestroyImmediate` > More elegant way of writing DestroyImmediate(gameObject).

## Logs

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
