﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCar : MonoBehaviour
{

    public float fallSpeed = 10;

    private bool falling;
    private bool fallen;

    private void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("SFX/bird") as AudioClip;
        audioSource.volume = .8f;
        audioSource.Play();
    }

    private void Update()
    {
        if (falling)
        {
            Vector3 rotation = transform.eulerAngles;
            rotation.x += fallSpeed * GameTime.deltaTime;
            transform.eulerAngles = rotation;

            if (transform.eulerAngles.x > 90)
            {
                falling = false;
                fallen = true;

                rotation = transform.eulerAngles;
                rotation.x = 90;
                transform.eulerAngles = rotation;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!fallen)
        {
            falling = true;

            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = Resources.Load("SFX/tree") as AudioClip;
            audioSource.volume = .8f;
            audioSource.Play();
        }
    
    }
}