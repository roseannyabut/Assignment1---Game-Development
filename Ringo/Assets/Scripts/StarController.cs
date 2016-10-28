/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 26, 2016 
Date last Modified: 	Oct 25, 2016
Program description: 	Moves the star right to left with a random position.
Revision History:		Oct 24 version 1.0
						Oct 25 version 1.1
*/

using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = Vector2.zero;

	private Transform _transform; 
	// variable computes the star movement
	private Vector2 _currentPosition; 
	//positive go left
	private int direction = 1;

	// Use this for initialization
	void Start () {

		_transform = gameObject.transform;
		_currentPosition = _transform.position;
		Reset ();

	}

	// Update is called once per frame
	void FixedUpdate () {

		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (speed.x, 0);
		_transform.position = _currentPosition; // updating the speed

		if (_currentPosition.x <= -5.3) {
			Reset (); 
		}
	}

	public void Reset(){
		// change the star in random position
		direction = -direction;
		float currentY = Random.Range (2.5f, 5.9f); 
		_currentPosition = new Vector2 (direction*6.5f, currentY);
		_transform.position = _currentPosition;
	}
}

