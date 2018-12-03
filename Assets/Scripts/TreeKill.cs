using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeKill : MonoBehaviour {

    public float fallSpeed = 10;
    public int direction = 1;

    private bool falling;
    private bool fallen;

    private void Update()
    {
        if (falling)
        {
            Vector3 rotation = transform.eulerAngles;
            rotation.z += fallSpeed * GameTime.deltaTime * direction;
            transform.eulerAngles = rotation;

            if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
            {
                falling = false;
                fallen = true;

                rotation = transform.eulerAngles;
                rotation.z = 90 * direction;
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
