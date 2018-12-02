using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float speed = 0;

    void Update()
    {
        transform.Translate(Vector3.right * GameTime.deltaTime * speed);
    }
}
