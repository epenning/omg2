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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            maxDeceleration = 1000;
            Crash();
        }
    }

    public void StartMoving()
    {
        speed = maxSpeed;
    }

    private void OnMouseDown()
    {
        Crash();
    }

    public void Crash()
    {
        deceleration = maxDeceleration;

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("SFX/Explosion 1") as AudioClip;
        audioSource.Play();

        AudioSource audioSource2 = gameObject.AddComponent<AudioSource>();
        audioSource2.clip = Resources.Load("SFX/Scream") as AudioClip;
        audioSource2.Play();
    }
}

