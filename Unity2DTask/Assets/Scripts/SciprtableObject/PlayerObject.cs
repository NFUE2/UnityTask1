using UnityEngine;
using UnityEngine.Animations;

[CreateAssetMenu(fileName = "DefaultScriptableObject",menuName = "Scriptable/Player",order = 0)]
public class PlayerObject : ScriptableObject
{
    public Sprite CharacterIdle;
    public RuntimeAnimatorController contorller;
}
