﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    private void OnMouseDown()
    {
            GetComponent<Deadly>().enabled = false;
    }
}
