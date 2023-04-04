using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAsset : MonoBehaviour
{
    AssetBundle testLoadBundle;
    public string path;
    public string nameA;

    // Start is called before the first frame update
    void Start()
    {
        LoadAssetBundle(path);
        AssetInsitantate(nameA);
    }

    void LoadAssetBundle(string bundlePath)
    {
        testLoadBundle = AssetBundle.LoadFromFile(bundlePath);
        Debug.Log(testLoadBundle == null ? "Failed" : "Pass");
    }
    
    void AssetInsitantate(string assetName)
    {
        var objPrefab = testLoadBundle.LoadAsset(assetName);
        Instantiate(objPrefab);
    }
}
