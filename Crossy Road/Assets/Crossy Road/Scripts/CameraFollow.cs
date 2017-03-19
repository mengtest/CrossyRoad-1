﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public bool autoMove = true;
	public GameObject player = null;
	public float speed = 0.25f;
	public Vector3 offset = new Vector3(3, 6, -3);
	Vector3 depth = Vector3.zero;
	Vector3 pos = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// TODO: Manager -> CanPlay ()

		if (autoMove)
		{
			depth = gameObject.transform.position += new Vector3(0, 0,speed * Time.deltaTime);
			pos = Vector3.Lerp(gameObject.transform.position, player.transform.position + offset, Time.deltaTime);
			gameObject.transform.position = new Vector3(pos.x, offset.y, depth.z);
		} else
		{
			pos = Vector3.Lerp(gameObject.transform.position, player.transform.position + offset, Time.deltaTime);
			gameObject.transform.position = new Vector3(pos.x, offset.y, pos.z);
		}

	}
}