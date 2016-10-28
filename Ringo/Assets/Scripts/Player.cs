/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 27,2016 
Date last Modified: 	Oct 26, 2016
Program description: 	The singleton class updating the labels of 
						health, score and best score. 
Revision History:		Oct 26 version 1.0
						Oct 27 version 1.1
*/

using UnityEngine;
using System.Collections;

public class Player {

	private const string key = "BEST_SCORE";
	private Player(){
		//get best score from the player pref if exist
		if (PlayerPrefs.HasKey (key)) {
			_bestScore = PlayerPrefs.GetInt (key);
		}
	}

	private static Player _instance = null;

	public static Player Instance{

		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}

			return _instance;				
		}
	}

	public HUDController hud = null;
	private int _score = 0;

	public int Score{
		
		get{ return _score; }
		set{ _score = value; 
			BestScore = _score;
			hud.UpdateScore ();
		}
	}

	private int _bestScore = 0;

	public int BestScore{

		get{ return _bestScore; }
		set{ 
			if (value > _bestScore) {
				_bestScore = value; 
				PlayerPrefs.SetInt (key, _bestScore);
			}
		}
	}
		

	private int _health = 1000;

	public int Health{

		get{ return _health; }
		set{ _health = value; 
			hud.UpdateHealth ();
			if (_health <= 0) {
				hud.GameOver ();
			}
		}
	}
}
