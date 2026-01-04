# Rig Deformation System

A reusable module for procedural application of bone-scale deformation to character rigs using data-driven profiles. This is part of a solution to create visual transformation of a character model.

---

## What it does

- Defines a shared set of bone identifiers (`BoneKeyDefinition`)
- Stores per-bone scale data in profiles (`BoneScaleProfile`)
- Builds a runtime rig from a character hierarchy (`RigFactory`)
- Blends between scale profiles efficiently at runtime (`RigBlender`)
- Supports pluggable interpolation logic (`IScaleInterpolator`)

Documentation has been added to key classes and interfaces.

---

## Design principles

- **Reusable module** – `Andre.RigDeformation` namespace is independent of demo or presentation code
- **Data-driven** – deformation behavior defined via ScriptableObjects
- **Runtime-safe** – assets are immutable at runtime
- **Performance-aware** – dictionary lookups, no per-frame allocations

---

## What this system does NOT handle

- Asset loading (Resources / Addressables)
- Animation timing or sequencing
- MonoBehaviour lifecycles
- Scene setup or presentation logic

These concerns belong to the consuming project.

---

## Demo project

The `Andre.Demo` namespace contains a reference implementation showing how to:

- Load assets
- Drive blending over time
- Integrate with a character prefab

The demo is optional and not required to use the system.

---

## Version

**v1.0.0** – Bone scale deformation with profile blending