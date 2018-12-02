﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    private static readonly System.Random random = new System.Random();

    public GameObject planePrefab;
    public List<GameObject> obstaclePrefabs;

	public void SpawnNextLevel(Level currentLevel)
    {
        Vector3 newPosition = GetNewPosition(currentLevel);
        GameObject obstaclePrefab = PickObstacle();

        GameObject nextLevelRoot = new GameObject("Level");
        nextLevelRoot.transform.SetPositionAndRotation(newPosition, Quaternion.identity);
        Level nextLevel = nextLevelRoot.AddComponent<Level>();
        nextLevel.CreateLevel(planePrefab, obstaclePrefab);
    }

    public Vector3 GetNewPosition(Level currentLevel)
    {
        Vector3 oldPosition = currentLevel.transform.position;
        float length = 10 * currentLevel.plane.transform.localScale.z;
        return new Vector3(oldPosition.x, oldPosition.y, oldPosition.z + length);
    }

    public GameObject PickObstacle()
    {
        if (obstaclePrefabs.Count == 0)
        {
            return null;
        }

        int index = random.Next(obstaclePrefabs.Count);
        return obstaclePrefabs[index];
    }
}
