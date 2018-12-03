using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaPeel : MonoBehaviour {

    public float power = 1000;
    private float mouseX;

    private void OnMouseDown()
    {
        mouseX = GetMouseX();

        AudioSource audioSource = gameObject.transform.parent.gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("SFX/Banana") as AudioClip;
        audioSource.Play();
    }

    private void OnMouseDrag()
    {
        float newMouseX = GetMouseX();
        float mouseXChange = newMouseX - mouseX;

        transform.Translate(Vector3.right * GameTime.deltaTime * mouseXChange);

        mouseX = newMouseX;
    }

    private float GetMouseX()
    {
        return Input.mousePosition.x / Screen.width * power;
    }
}
