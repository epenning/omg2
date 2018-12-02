using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public GameObject plane;
    public GameObject obstacle;

    public void CreateLevel(GameObject planePrefab, GameObject obstaclePrefab)
    {
        if (plane == null)
        {
            MakePlane(planePrefab);
        }

        if (obstaclePrefab)
        {
            obstacle = Object.Instantiate(obstaclePrefab, transform);
        }
    }

    private void MakePlane(GameObject planePrefab)
    {
        plane = Object.Instantiate(planePrefab, transform);
        LoopingPlane loopingPlane = plane.GetComponent<LoopingPlane>();
        loopingPlane.level = this;
    }

    public void RemoveLevel()
    {
        Destroy(gameObject);
    }
}
