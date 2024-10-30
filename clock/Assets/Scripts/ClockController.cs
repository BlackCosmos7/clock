using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockController : MonoBehaviour
{
    public Transform hour;
    public Transform min;
    public Transform sec;
    public TMP_InputField hourInput;
    public TMP_InputField minInput;
    public TMP_InputField secInput;


    public void UpdateClock()
    {
        if (float.TryParse(hourInput.text, out float hourAngle))
        {
            hour.localRotation = Quaternion.Euler(0, 0, -hourAngle);
        }

        if (float.TryParse(minInput.text, out float minuteAngle))
        {
            min.localRotation = Quaternion.Euler(0, 0, -minuteAngle);
        }

        if (float.TryParse(secInput.text, out float secondAngle))
        {
            sec.localRotation = Quaternion.Euler(0, 0, -secondAngle);
        }
    }
}
