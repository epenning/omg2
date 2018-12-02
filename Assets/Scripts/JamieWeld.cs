using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamieWeld : MonoBehaviour {

    public float speed = 0;
	
	void Update () {
        transform.Translate(Vector3.forward * GameTime.deltaTime * speed);
	}
}
