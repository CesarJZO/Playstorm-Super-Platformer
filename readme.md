﻿# Playstorm Super Platformer

Esto es un platformer 2D hecho en Unity por **[Playstorm Studios](https://playstormstudios.com/)** para el curso de **Unity for Dummies**.

![Gameplay](./images/game.gif)

## Scripts

Este es un ejemplo de como hacer un script en **C#** para **Unity**. Todos los scripts del proyecto están en la carpeta [Scripts](./Assets/Scripts/).

```csharp
public class MyScript : MonoBehaviour
{
    // Se ejecuta una vez al inicio
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Se ejecuta una vez por frame
    void Update()
    {
        Debug.Log("Hello World!");
    }
}
```

## Animaciones

Las animaciones se están guardadas en la carpeta de [Animations](./Assets/Animations/). Y sus *sprites* se encuentran en la carpeta [Sprites](./Assets/Sprites/).

![Animator](./images/animator.png)

## Escenas

Los niveles, menús y elementos que forman el juego se organizan en escenas. Están en [Scenes](./Assets/Scenes/).

## Recursos extra

- [Paquete con animaciones](./Resources/PlaystormResources.unitypackage) Nuestros recursos con animaciones y sprites.
- [Unity Manual](https://docs.unity3d.com/Manual/index.html) El manual oficial de Unity.
- [Unity Scripting API](https://docs.unity3d.com/ScriptReference/index.html) Donde está toda la documentación de las clases y funciones de Unity.
- [Unity Learn](https://learn.unity.com/) Cursos y tutoriales hechos por Unity.
