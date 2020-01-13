## Changelog (1-12-2020 // ~8:50)
 - Changed solution and project name
 - Added some instructions to the README =D

# Unity Utilities
 Utilities to improve the C# experience in Unity: ranging from extension methods to shorter code length.
 
 For now to use this library, you need to copy the repo (or download it) and build a .dll file in Visual Studio, Jetbrains Rider or any .NET IDE, to then add it to your Unity project! Alternatively, you can also copy all the scripts in your project and add the namespaces where you need them :)
 
# Extension Methods

## Numerals : takes any type of number (float, int, double) and returns it in the same type 
 - `Abs` > Returns the absolute value.
 
## Float
 - `Round` > Rounds float and returns int.
 
## Int


## Vectors
 - `VectorFromAngleRad` > Returns the corresponding vector to the given angle (in radians).
 - `VectorFromAngleDeg` > Returns the corresponding vector to the given angle (in degrees).
 - `RotateByAngleRad` > Rotates the Vector2 by the given angle (in radians).
 - `RotateByAngleDeg` > Rotates the Vector2 by the given angle (in degrees).
 - `AngleFromVectorRad` > Returns the positive angle in degrees of given Vector2. This method assumes +X axis is 0 degrees.
 - `AngleFromVectorDeg` > Returns the positive angle in radians of given Vector2. This method assumes +X axis is 0 degrees. 
 - `Round` > Rounds Vector2 and Vector3

# Code Shorteners
 - `Print` > Cleaner way of Debug.Log() with message type support
 - `Destroy()` > More elegant way of writing Destroy(gameObject).