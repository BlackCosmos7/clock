using UnityEngine;
using UnityEngine.UI; 
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TextClock : MonoBehaviour
{
    public TextMeshProUGUI timeText; 
    private float seconds; 

    void Start()
    {
        seconds = 0f; 
    }

    void Update()
    {
        seconds += Time.deltaTime;
        int minutes = (int)(seconds / 60);
        int hours = minutes / 60;
        int displaySeconds = (int)(seconds % 60);
        int displayMinutes = minutes % 60;
        string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, displayMinutes, displaySeconds);
        timeText.text = formattedTime;
    }
}