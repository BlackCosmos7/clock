using UnityEngine;

public class Sec : MonoBehaviour
{
    public float seconds; 
    public float speed = 6f; 

    void Update()
    {
        seconds += Time.deltaTime;
        float rotationAngle = seconds * speed;
        transform.rotation = Quaternion.Euler(0, 0, -rotationAngle);
        
        if (seconds >= 60f)
        {
            seconds = 0f;
        }
    }
}
