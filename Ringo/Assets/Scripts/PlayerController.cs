/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 25, 2016 
Date last Modified: 	Oct 25, 2016
Program description: 	Controls the player by the user input 
						using arrow keys or WASD on the keyboard.
Revision History:		Oct 24 version 1.0
						Oct 25 version 1.1
*/


using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	[SerializeField]
	private float speed;
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;
	private float _playerInput1;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		//get the input from the user
		//and determines if horizontal or vertical
		_playerInput = Input.GetAxis("Vertical");
		_playerInput1 = Input.GetAxis("Horizontal");
		_currentPosition = _transform.position;

		if(_playerInput > 0){
			_currentPosition += new Vector2(0, speed);
		}
		if (_playerInput < 0){
			_currentPosition -= new Vector2(0, speed);
		}
		if (_playerInput1 > 0){
			_currentPosition += new Vector2(speed, 0);
		}
		if (_playerInput1 < 0){
			_currentPosition -= new Vector2(speed, 0);
		}

		checkBound();
		_transform.position = _currentPosition;
	}


	//checks the bounds for x and y axis 
	private void checkBound()
	{
		if (_currentPosition.x < -7.14f){
			_currentPosition.x = -7.14f;
		}
		if (_currentPosition.x > 4.3f){
			_currentPosition.x = 4.3f;
		}
		if (_currentPosition.y < -6.5f){
			_currentPosition.y = -6.5f;
		}
		if (_currentPosition.y > 4.84f){
			_currentPosition.y = 4.84f;
		}
	}
}