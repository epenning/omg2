using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadly : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            GameTime.timeMultiplier = 1;
            SceneManager.LoadScene(0);
        }
    }
}
