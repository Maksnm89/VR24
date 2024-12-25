using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public Text text_null;
    public GameObject box;
    public void ClickBut()
    {
        box.SetActive(!(box.activeSelf));
    }
}