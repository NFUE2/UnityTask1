using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChoiceName : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] CharacterStat characterStat;
    [SerializeField] GameObject background;

    public void CheckText()
    {
        string str = text.text;

        if (str.Length < 2 || 10 < str.Length) return;
        characterStat.SetNickname(str);

        background.SetActive(false);
        gameObject.SetActive(false);
    }
}
