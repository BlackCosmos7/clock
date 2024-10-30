using UnityEngine;

public class Hour : MonoBehaviour
{
    public float hours;
    private float speed = 30f;

    void Update()
    {
        hours += Time.deltaTime / 3600f; 
        float rotationAngle = hours * speed;
        transform.rotation = Quaternion.Euler(0, 0, -rotationAngle);

        if (hours >= 12f)
        {
            hours = 0f;
        }
    }
}