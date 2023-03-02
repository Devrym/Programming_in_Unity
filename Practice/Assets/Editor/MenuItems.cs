using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuItems
{
    [MenuItem("Geekbrains/����� ���� No0 ")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
    }
    [MenuItem("Geekbrains/����� ���� No1 %#a")]
    private static void NewMenuOption()
    {
    }
    [MenuItem("Geekbrains/����� ���� No2 %g")]
    private static void NewNestedOption()
    {
    }
    [MenuItem("Geekbrains/����� ���� No3 _g")]
    private static void NewOptionWithHotkey()
    {
    }
    [MenuItem("Geekbrains/����� ����/����� ���� No3 _g")]
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
