using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStat : MonoBehaviour
{
    public Text nicknameText;

    public void SetNickname(string name)
    {
        nicknameText.text = name;
    }
}
