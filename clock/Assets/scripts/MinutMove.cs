using UnityEngine;

public class Min : MonoBehaviour
{
    public float minutes; 
    private float speed = 0.1f; 

    void Update()
    {
        minutes += Time.deltaTime / 60f; 
        float rotationAngle = minutes * 360f / 60f;
        transform.rotation = Quaternion.Euler(0, 0, -rotationAngle);
        if (minutes >= 60f)
        {
            minutes = 0f;
        }
    }
}
