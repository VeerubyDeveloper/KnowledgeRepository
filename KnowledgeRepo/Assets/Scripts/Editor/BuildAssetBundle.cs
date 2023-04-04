using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildAssetBundle : Editor
{
    [MenuItem("Assets/NewAssetBundle")]
    static void assetBundles()
    {
        BuildPipeline.BuildAssetBundles(@"C:\Users\TUF GAMING\Documents\GitHub\KnowledgeRepository\Assetbundle Output", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }

}
