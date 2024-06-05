# CHARACTER CONTROLLER

[SOURCE](https://youtu.be/e94KggaEAr4?list=PLwyUzJb_FNeQrIxCEjj5AMPwawsw5beAy)

Character Controller: Component(s) that provides ==movement to our character== + ==interact with colliders== (floor, stair, environment,...)

## [CharacterController](https://docs.unity3d.com/ScriptReference/CharacterController.html)

- CharacterController = Collider + built-in Character Controller (Wrapper around Unity's PhysX engine's character controller)
- Some features: Stairs, Slopes, Uneven Ground, Collision Detection,... 
- Properties and Methods ready to be use
- Simple and fastest to implementation
- Not impacted by other kinematic game object or rigdibody game objects, physics forces (Friction, momentum,...),... => Must program features
- Method SimpleMove (by default) apply gravity
- Move up and down slopes of set degree angles and can handle stair. Built-in won't  automatically slide down slopes if on highly-angled slope
- Can detects is touching ground

## Rigidbody

- Component allow game objects to interact with Unity's physics in real-time. When use this, game object will be included in the physics system.
- Add Collider and the Unity's Physics system will handle Collision Detection
- Properties and Methods ready to be use
- Kinematic/Dynamic:

### Kinematic

- Disregards incoming physics forces from the game object, isn't moved by collisions. 
- Object isn't static so it's intended to move. 
- _Can benefit from collision detection but handle how it moves and how it reacts from collisions with our own code._
- Only impact other physics objects
- Not impacted by other kinematic game object or rigdibody game objects, physics forces (Friction, momentum,...),... => Must program features

### Dynamic

- Is physics-based, abide by the "laws" of Unity's physics engine. 
- Directly Impact and impacted by all physics forces
- Interact with physics
- Auto slide down slope but not stop in place with right amount of drag. Doesn't handle steps the same way as the built-in character controller
- Must check touching ground

| BUILT-IN            | DYNAMIC                 | KINEMATIC  | CUSTOM ==REQUIREMENTS== |
| ------------------- | ----------------------- | ------------------------------------ |
| STAIR HANDLING      | BUILD IN GRAVITY        | STAIR HANDLING                       |
| SLOPE TRAVERSAL     | MOMENTUM-BASED MOVEMENT | BUILD IN GRAVITY                     |
| SNAPPY MOVEMENT     | PHYSICS INTERACTION     | SLOPE TRAVERSAL                      |
| GROUND DETECTION    | COLLISION DETECTION     | MOMENTUM-BASED MOVEMENT              |
| COLLISION DETECTION |                         | SNAPPY MOVEMENT                      |
|                     |                         | GROUND DETECTION                     |
|                     |                         | COLLISION DETECTION                  |
|                     |                         | PHYSICS INTERACTION                  |
**_CUSTOM CHARACTER CONTROLLER IS THE MOST COMPLEX BUT IT'S ALSO THE MOST FLEXIBLE**_