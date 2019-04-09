using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrefabLoader.LoadPrefab("ui/prefabs.u3dassetbundle", "Canvas", LoadCallBack);
    }

    void LoadCallBack(UnityEngine.Object obj)
    {
        GameObject go = Instantiate<GameObject>(obj as GameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
