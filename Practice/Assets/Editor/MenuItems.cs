using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuItems
{
    [MenuItem("Geekbrains/Пункт меню No0 ")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
    }
    [MenuItem("Geekbrains/Пункт меню No1 %#a")]
    private static void NewMenuOption()
    {
    }
    [MenuItem("Geekbrains/Пункт меню No2 %g")]
    private static void NewNestedOption()
    {
    }
    [MenuItem("Geekbrains/Пункт меню No3 _g")]
    private static void NewOptionWithHotkey()
    {
    }
    [MenuItem("Geekbrains/Пункт меню/Пункт меню No3 _g")]
    private static void NewOptionWithHot()
    {
    }
    [MenuItem("Assets/Geekbrains")]
    private static void LoadAdditiveScene()
    {
    }
    [MenuItem("Assets/Create/Geekbrains")]
    private static void AddConfig()
    {
    }
    [MenuItem("CONTEXT/Rigidbody/Geekbrains")]
    private static void NewOpenForRigidBody()
    {
    }
}
