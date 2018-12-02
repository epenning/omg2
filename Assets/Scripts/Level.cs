using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public GameObject root;
    public GameObject plane;
    public GameObject obstacle;

    public Level(Vector3 position, GameObject planePrefab, GameObject obstaclePrefab)
    {
        root = Object.Instantiate(new GameObject("Level"), position, Quaternion.identity);
        MakePlane(planePrefab);

        if (obstaclePrefab)
        {
            obstacle = Object.Instantiate(obstaclePrefab, root.transform);
        }
    }

    private void MakePlane(GameObject planePrefab)
    {
        plane = Object.Instantiate(planePrefab, root.transform);
        LoopingPlane loopingPlane = plane.GetComponent<LoopingPlane>();
        loopingPlane.level = this;
    }

    public void RemoveLevel()
    {
        Object.Destroy(root);
    }
}
