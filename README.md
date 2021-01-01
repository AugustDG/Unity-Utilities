# Unity Utilities

Utilities to improve the C# experience in Unity: ranging from extension methods to shorter code length.

For now to use this library, you need to copy the repo (or download it) and build a .dll file in Visual Studio,
Jetbrains Rider or any .NET IDE, to then add it to your Unity project! Alternatively, you can also copy all the scripts
in your project :) Don't forget to add the `Utilities` namespace!

# Extensions

## Numerals : takes any type of number (float, int, double) and returns it in the same type

- `Abs` > Returns the absolute value.

## Float

- `RoundToInt` > Rounds float and returns int.

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
- `Round` > Rounds Vector2 and Vector3

# Code Shorteners

- `Print` > Cleaner way of Debug.Log() with message type support
- `Destroy` > More elegant way of writing Destroy(gameObject).

## Logs

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
