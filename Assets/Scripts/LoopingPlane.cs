using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingPlane : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //when you enter the game we want to copy the plane forward so there is a consistent loop of the plane.
            Vector3 oldPosition = gameObject.transform.position;
            Vector3 newPosition = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z + 100);
            Object.Instantiate(gameObject, newPosition, gameObject.transform.rotation);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //when player exits the plane, it will be deleted.
            GameObject.Destroy(gameObject);
        }
    }
}
