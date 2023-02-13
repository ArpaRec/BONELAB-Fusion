﻿using UnityEngine;
using UnityEditor;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Diagnostics;

public class ExtraToolsEditor : EditorWindow
{
    [MenuItem("BONELAB Fusion/Build AssetBundles (Windows)")]
    static void BuildAllAssetBundlesWindows()
    {
        string assetBundleDirectory = "Assets/AssetBundles/StandaloneWindows64";
        Directory.CreateDirectory(assetBundleDirectory);
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }

    [MenuItem("BONELAB Fusion/Build AssetBundles (Android)")]
    static void BuildAllAssetBundlesAndroid()
    {
        string assetBundleDirectory = "Assets/AssetBundles/Android";
        Directory.CreateDirectory(assetBundleDirectory);
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }

    [MenuItem("BONELAB Fusion/Remove All AssetBundles")]
    static void RemoveAssetBundles() {
        var names = AssetDatabase.GetAllAssetBundleNames();
        foreach (string name in names)
            AssetDatabase.RemoveAssetBundleName(name, true);
    }
}
