using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float speed = 0;
    public float deceleration = 0;

    void Update()
    {
        if (Mathf.Abs(speed) < deceleration)
        {
            speed = 0;
        } else if (speed > 0)
        {
            speed -= deceleration;
        } else if (speed < 0)
        {
            speed += deceleration;
        }

        transform.Translate(Vector3.right * GameTime.deltaTime * speed);
    }

    private void OnMouseDown()
    {
        deceleration = 0.1f;
    }
}
