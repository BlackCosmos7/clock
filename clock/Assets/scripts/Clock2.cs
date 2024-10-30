using UnityEngine;

public class Clock2 : MonoBehaviour
{
    public Transform sec; 
    public Transform min; 
    public Transform hour;   

    private float seconds;
    private float minutes;
    private float hours;

    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds >= 60f)
        {
            seconds = 0f;
            minutes++;
        }

        if (minutes >= 60f)
        {
            minutes = 0f;
            hours++;
        }

        float secondRotation = seconds * 6f; 
        float minuteRotation = (minutes + seconds / 60f) * 6f; 
        float hourRotation = (hours + minutes / 60f) * 30f; 

        // Поворачиваем стрелки
        sec.rotation = Quaternion.Euler(0, 0, -secondRotation);
        min.rotation = Quaternion.Euler(0, 0, -minuteRotation);
        hour.rotation = Quaternion.Euler(0, 0, -hourRotation);
    }
}
