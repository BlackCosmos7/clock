using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    public GameObject objectToMove; 
    public InputField inputField; 

    public void Move()
    {
        if (float.TryParse(inputField.text, out float moveAmount))
        {
            objectToMove.transform.position += new Vector3(moveAmount, 0, 0);
        }
        else
        {
            Debug.Log("¬ведите корректное число!");
        }
    }
}