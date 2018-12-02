using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingPlane : MonoBehaviour {

    private LevelController levelController;

    public Level level;

    private void Start()
    {
        levelController = FindObjectOfType(typeof(LevelController)) as LevelController;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //when you enter the game we want to make a new level.
            levelController.SpawnNextLevel(level);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //when player exits the plane, it will be deleted.
            level.RemoveLevel();
        }
    }
}
