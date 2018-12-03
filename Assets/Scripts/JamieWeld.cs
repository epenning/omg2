using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamieWeld : MonoBehaviour {

    public float speed = 0;
    public int framesPerFlip = 10;
    public int deathSpinSpeed = 1000;

    private SpriteRenderer sprite;
    private int framesSinceFlip = 0;
    private bool dead = false;

    private void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Update () {
        if (!dead)
        {
            transform.Translate(Vector3.forward * GameTime.deltaTime * speed);

            framesSinceFlip++;
            if (framesSinceFlip > framesPerFlip)
            {
                framesSinceFlip = 0;
                sprite.flipX = !sprite.flipX;
            }
        }
        else
        {
            Vector3 rotation = sprite.transform.eulerAngles;
            rotation.z += deathSpinSpeed * GameTime.deltaTime;
            sprite.transform.eulerAngles = rotation;
        }
    }

    public void Die()
    {
        dead = true;

        Camera camera = FindObjectOfType<Camera>();
        camera.gameObject.transform.SetParent(gameObject.transform.parent);
    }
}
