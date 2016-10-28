/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 26, 2016 
Date last Modified: 	Oct 25, 2016
Program description: 	This determine to  increase the score or decrease the health and 
						showing the explosion when colliding with the enemy. 
Revision History:		Oct 24 version 1.0
						Oct 25 version 1.1
						Oct 26 version 1.2
*/

using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	[SerializeField]
	GameObject explosion = null;

	void OnTriggerEnter2D(Collider2D other){
		
		//when star collide with Ringo the score increases 
		if (other.gameObject.tag == "Lives") {

			//checks the collision if happening
			Debug.Log ("Collision with the star");
			Player.Instance.Score =  Player.Instance.Score + 10;
			StarController sc = other.gameObject.GetComponent<StarController> ();

			if (sc != null){
				sc.Reset ();
			}
		} 

		else if(other.gameObject.tag == "Enemy"){
			//checks the collision if happening
			Debug.Log ("Collision with the enemy");

			//when enemies collide with Ringo it decreases the health
			Player.Instance.Health = Player.Instance.Health - 100;

			//get all the components on enemy controller 
			EnemyController pc = other.gameObject.GetComponent<EnemyController> ();

			//show explosion
			GameObject e = Instantiate(explosion);
			e.transform.position = other.gameObject.transform.position;

			//play the explosion sound
			AudioSource sound = gameObject.GetComponent<AudioSource> ();
			if (sound != null) {
				sound.Play ();
			}

			if (pc != null) {
				pc.Reset ();
			}
		}
	}
}
