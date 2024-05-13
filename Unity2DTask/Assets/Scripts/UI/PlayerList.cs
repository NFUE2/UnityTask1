using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerList : MonoBehaviour
{
    public Transform playerListTransform;
    public Text textFrame;

    private void Start()
    {
        CharacterStat[] obj = FindObjectsOfTypeAll(typeof(CharacterStat)) as CharacterStat[];

        foreach(CharacterStat stat in obj)
        {
            Debug.Log(stat.nicknameText.text);
            AddUser(stat.nicknameText.text);
        }
    }

    public void AddUser(string name)
    {
        Text text = Instantiate(textFrame, playerListTransform);
        text.text = name;
    }
}