This is a proof-of-concept for a procedural rig deformation system. It is intended to be used as part of a larger game project which centers around a shapeshifting game mechanic. The purpose is to get awesome visual transformations of the 3D player character.

- It uses dependency injection, handled in Boot.cs
- Separation of concerns: the system functionality is found in the CharacterDeformation folder, while the Demo folder holds scripts related to the specific project (in this case a visual demonstration).
- Interface abstractions in the system layer are concretized in the project layer.
- Everything is handled from scripts, including asset instantiation and component handling (see AssetsFactory.cs).