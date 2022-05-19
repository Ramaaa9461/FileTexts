using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAssetController : MonoBehaviour
{
    [SerializeField] TextAsset textAsset;
    [SerializeField] Text text;


    private void Start()
    {
        text.text = textAsset.text;
    }


}
