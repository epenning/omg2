using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamieWeld : MonoBehaviour {

    public float speed = 0;
    public int framesPerFlip = 10;

    private SpriteRenderer sprite;
    private int framesSinceFlip = 0;

    private void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Update () {
        transform.Translate(Vector3.forward * GameTime.deltaTime * speed);

        framesSinceFlip++;
        if (framesSinceFlip > framesPerFlip)
        {
            framesSinceFlip = 0;
            sprite.flipX = !sprite.flipX;
        }
    }
}
