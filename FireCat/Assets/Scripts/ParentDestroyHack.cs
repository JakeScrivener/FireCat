﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDestroyHack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KILLYOURSELF()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
