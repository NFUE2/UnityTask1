using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChoiceName : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject player;
    public void CheckText()
    {
        string str = text.text;

        if (str.Length < 2 && 10 < str.Length) return;


    }
}
