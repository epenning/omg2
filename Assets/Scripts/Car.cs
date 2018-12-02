using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float maxSpeed = -4;
    public float speed = 0;
    public float deceleration = 0;
    public float maxDeceleration = 0.1f;

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
        deceleration = maxDeceleration;
    }

    public void StartMoving()
    {
        speed = maxSpeed;
    }
}
