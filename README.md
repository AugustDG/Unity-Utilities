# Unity Utilities

Utilities to improve the C# experience in Unity: ranging from more capabilities to shorter code length!

For now, to use this library, you need to copy the repo (or download it) and build a .dll file in Visual Studio,
Jetbrains Rider or any .NET IDE, to then add it to your Unity project! Alternatively, you can also copy all the scripts
in your project :) Don't forget to add the `UnityUtilities` namespace!

## C# Version

Currently frozen at [#8.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8) for backwards compability
with `Unity 2020.2` and above!

## Patterns

A series of popular programming patterns, implemented in easy to use classes!

### Singletons

Through the controversy of using them, here are generic,
base [Singleton](https://en.wikipedia.org/wiki/Singleton_pattern#:~:text=In%20software%20engineering%2C%20the%20singleton,mathematical%20concept%20of%20a%20singleton.)
classes to get you up and going if you need them!  

**Since Unity is singlethreaded, none of the following are thread safe!**

- `Singleton` &rarr; Generic singleton class, made for _MonoBehaviours_.
- `SingletonPersistent` &rarr; Generic persistent singleton class, made for _MonoBehaviours_. Persists through scene reloads.
- `SingletonLazy` &rarr; Generic lazy singleton class, made for _MonoBehaviours_. Creates itself, if it doesn't exist.
- `SingletonService` &rarr; A newer kind of a C# (doesn't interact with Unity) _Singleton_, only accessible through method calls. Mainly used for services.

## Extensions

### Numerals

- `Round` &rarr; Rounds float and returns float; number of decimals can be specified.
- `RoundToInt` &rarr; Rounds float and returns int.
- `Abs` &rarr; Returns the absolute value (of ints and floats).
- `Clamp` &rarr; Clamps float or int to the supplied range.
- `Map` &rarr; Maps a float from the supplied range to the supplied range (for floats and ints).

### Movement

- `GoUp` &rarr; Smoothly translates the _gameobject_ (or transform) up at the desired speed (float).
- `GoDown` &rarr; Smoothly translates the _gameobject_ (or transform) down at the desired speed (float).
- `GoLeft` &rarr; Smoothly translates the _gameobject_ (or transform) left at the desired speed (float).
- `GoRight` &rarr; Smoothly translates the _gameobject_ (or transform) right at the desired speed (float).
- `GoForward` &rarr; Smoothly translates the _gameobject_ (or transform) forward at the desired speed (float).
- `GoBackward` &rarr; Smoothly translates the _gameobject_ (or transform) backward at the desired speed (float).
- `FollowMouse2D` &rarr; Smoothly makes the _Rigidbody2D_ follow the mouse position at the desired speeds (float, float).
- `FollowObject2D` &rarr; Smoothly makes the _Rigidbody2D_ follow the specified object (or transform) at the desired
  speeds (float, float);

### Vectors

- `Round` &rarr; Rounds _Vector2_, _Vector3_ and returns a rounded vector with the specified number of decimals.
- `RoundToInt` &rarr; Rounds _Vector2_, _Vector3_ and returns _Vector2Int_.
- `Clamp` &rarr; Clamps the components of the Vector3 between supplied values.
- `VectorFromAngle` &rarr; Returns the corresponding vector to the given angle (in degrees or radians).
- `RotateByAngle` &rarr; Rotates the _Vector2_ by the given angle (in degress or radians). This method assumes +X axis
  is 0 degrees/radians.
- `AngleFromVector` &rarr; Returns the positive angle in degrees (or radians) of given _Vector2_. This method assumes +X
  axis is 0 degrees/radians.
- `TransformTo2DVector3` &rarr; Transforms _Vector2_ into _Vector3_ respecting Unity's coordinate system (so x = x, y =
  0, z = y).
- `ChopTo2DVector3` &rarr; Takes and returns a _Vector3_ respecting Unity's coordinate system (so x = x, y = 0 (or
  specified), z = y).
- `ToVector2` &rarr; Transforms a 2-big float array to a _Vector2_.
- `GeoDistanceTo` &rarr; Calculates distance between two coordinates.

### GameObject

- `Print` &rarr; Cleaner way of _Debug.Log()_ with log type support
- `DelayAction` &rarr; Delays supplied action by specified number of seconds (float).
- `IsAnimatorPlaying` &rarr; Checks if the animator is currently playing an animation.
- `Destroy` &rarr; More elegant way of writing _Destroy(gameObject)_.
- `DestroyImmediate` &rarr; More elegant way of writing _DestroyImmediate(gameObject)_.

## Changelog

### v0.1.2

Long time no see... Sorry, about that!

- Renamed files for a clearer project
- Added `IsAnimatorPlaying` to check whether an _Animator_ is currently playing an _Animation_
- Added _Patterns_ folder for useful programming patterns!
- Started setup for [upm](https://openupm.com/) hosting!

### 11-06-2021

- Added `MiscellaneousExtensions` for... miscellaneous extensions like `GeoDistance`!
- Moved miscellaneous section into its own script ^^!

### 19-05-2021

- Removed `ref` keyword (accident, sorry!)
- Changed all namespaces to `UnityUtilities`
- Added `ToVector2` to transform float arrays (of size 2) into a vector 2
- Added `GeoDistanceTo` to calculate distance between two geocoordinates

### 26-04-2021

- Removed `ValueType` method
- Changed all angle related methods to a single one for each use case, i.e. you now have to specify what unit of measure
  you are using :)
- All of the `GoUp`, `GoDown`, etc. methods can now be directly used for Transforms as well
- Separated each extension-related methods in their respective files (Numerals, GameObject, Vector, Unity (= Misc.))
- Removed `double` methods as it's rarely used in Unity

### 25-04-2021

Will probably remove the ValueType function as it can be used with a variety of things and can therefore introduce bugs
😅

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

### 1-01-2021

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

### 1-12-2020

- Changed solution and project name
- Added some instructions to the README =D
