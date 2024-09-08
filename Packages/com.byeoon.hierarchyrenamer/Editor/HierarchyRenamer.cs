using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using UnityEditor;
using UnityEngine;


public class HierarchyRenamer
{
    [InitializeOnLoadMethod]
    static void OnLoad()
    {
        UnityEngine.Debug.Log("[byeoon] HierarchyRenamer has loaded successfully!");
    }

    [MenuItem("byeoon/HierarchyRenamer")]
    static void OpenWindowFunc()
    {
        RenamerMenu.ShowWindow();
    }


}
