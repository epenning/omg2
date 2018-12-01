using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("entered");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
