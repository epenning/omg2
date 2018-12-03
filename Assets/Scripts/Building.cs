using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(gameObject);

        AudioSource audioSource = gameObject.transform.parent.gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("SFX/Explosion 2") as AudioClip;
        audioSource.Play();

        AudioSource audioSource2 = gameObject.AddComponent<AudioSource>();
        audioSource2.clip = Resources.Load("SFX/Scream") as AudioClip;
        audioSource2.Play();
    }
}
