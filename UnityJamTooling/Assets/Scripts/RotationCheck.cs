using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCheck : MonoBehaviour
{
    void Update()
    {

        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        //Ta Daaa
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, Mathf.Floor(angle/3)*3 - 180));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, Mathf.Floor(angle/3)*3 + 90));
        }
        
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
