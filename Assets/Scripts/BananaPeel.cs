using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaPeel : MonoBehaviour {

    private float mouseX;

    private void OnMouseDown()
    {
        mouseX = Input.mousePosition.x;
    }

    private void OnMouseDrag()
    {
        float newMouseX = Input.mousePosition.x;
        float mouseXChange = newMouseX - mouseX;

        transform.Translate(Vector3.right * Time.deltaTime * mouseXChange);

        mouseX = newMouseX;
    }
}
