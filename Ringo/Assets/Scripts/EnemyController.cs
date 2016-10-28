/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 26, 2016 
Date last Modified: 	Oct 25, 2016
Program description: 	The movement of the enemy randomly.
Revision History:		Oct 24 version 1.0
						Oct 25 version 1.1
*/

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {


	[SerializeField]
	private float speed;
	private Transform _transform;
	private Vector2 _currentPosition;
	private int direction = 1;

	// Use this for initialization
	void Start()
	{
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
		Reset();

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2(speed, 0);
		_transform.position = _currentPosition;
		if (_currentPosition.x <= -14.5f)
		{
			Reset();
		}
	}


	public void Reset()
	{
		direction = -direction;
		float currentY = Random.Range(-5f, 4f);
		_currentPosition = new Vector2(direction*30.9f, currentY);
		_transform.position = _currentPosition;


	}

}
