﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(0) ;		
		}
	}
	//Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
}
