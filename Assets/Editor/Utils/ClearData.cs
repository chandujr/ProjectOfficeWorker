using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClearData
{
    [MenuItem("Tools/Clear Player Prefs")]
    private static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Player Prefs cleared");
    }
}
