/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 26, 2016 
Date last Modified: 	Oct 25, 2016
Program description: 	This script is scrolling the background horizontally right to left. 
Revision History:		Oct 24 version 1.0
						Oct 25 version 1.1
*/


using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	[SerializeField]
	private float speed;
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;
		if (_currentPosition.x <= -20) {
			Reset ();
		}
	
	}

	public void Reset(){
		_currentPosition = new Vector2 (31f, -1.6f);
		_transform.position = _currentPosition;
	}
}
