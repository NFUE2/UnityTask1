using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText;
    
    private void Update()
    {
        DateTime today = DateTime.Now;
        timerText.text = $"{today.Hour}:{today.Minute}";
    }
}
