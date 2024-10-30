using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickAnim : MonoBehaviour
{
    private const float
    hourToDegrees = 360f / 12f,
    minToDegrees = 360f / 60f,
    secToDegrees = 360f / 60f;
    public Transform hour, min, sec;
    public bool analog;
    void Update()
    {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hour.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hourToDegrees);
            min.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * minToDegrees);
            sec.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hour.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hourToDegrees);
            min.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minToDegrees);
            sec.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secToDegrees);
        }
    }
}
