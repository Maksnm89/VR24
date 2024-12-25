using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
    public int a = 10;
    public Text count_collision;
    public void OnCollisionEnter(Collision collision)
    {
        a--;
        count_collision.text = a.ToString();
    }
}
