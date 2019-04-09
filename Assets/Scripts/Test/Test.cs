using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public string bundleName;
    public string assetName;
    NameTable nt;
    List<string> nameList;
    int index = 0;
    // Use this for initialization
    void Start ()
    {
        Image image = GetComponent<Image>();
        image.LoadSprite(bundleName, assetName);
        nt = GetComponent<NameTable>();
        StartCoroutine(LoadSprite());
        nameList = new List<string>();
        nameList.Add("btn_a");
        nameList.Add("btn_b");
        nameList.Add("btn_c");
        nameList.Add("btn_d");
        //AssetBundleFramework.AssetBundleMgr.GetInstance().DisposeAllAssets(AssetBundleFramework.BundleClassify.Normal);
    }

    void Update()
    {

    }

    IEnumerator LoadSprite()
    {
        while (enabled)
        {
            yield return null;
            if (nt != null)
            {
                nt.Find("Key1").GetComponent<Image>().LoadSprite("ui/images/playerview.u3dassetbundle", nameList[index % 4]);
                nt.Find("Key2").GetComponent<Image>().LoadSprite("ui/images/playerview.u3dassetbundle", nameList[index % 4]);
                nt.Find("Key3").GetComponent<Image>().LoadSprite("ui/images/playerview.u3dassetbundle", nameList[index % 4]);
                nt.Find("Key4").GetComponent<Image>().LoadSprite("ui/images/playerview.u3dassetbundle", nameList[index % 4]);
            }
            index++;
        }
    }
}
