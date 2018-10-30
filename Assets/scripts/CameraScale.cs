using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScale : MonoBehaviour
{


	public GameObject floorTile;
	
	//keep a list of spawned tiles
	private List<GameObject> myTileList = new List<GameObject>();
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < myTileList.Count; i++)
		{
			//myTileList[i].GetComponent<>;
		}
	}
//DYNAMIC CAMERA:
// position the camera to center itself based on your generated world...
// 1. keep a list of all your spawned tiles
// 2. then calculate the average position of all of them (use a for() loop to go through the whole list) 
// 3. then move your camera to that averaged center and make sure fieldOfView is wide enough?
}
