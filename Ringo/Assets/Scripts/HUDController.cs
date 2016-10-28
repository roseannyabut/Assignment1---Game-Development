/*
Source file name: 		Ringo
Author’s name: 			Rose Ann M. Yabut
Last Modified: 			Oct 27,2016 
Date last Modified: 	Oct 26, 2016
Program description: 	This control display for labels and 
						button and can deactivate them in play mode.
Revision History:		Oct 26 version 1.0
						Oct 27 version 1.1
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text scoreLabel = null;

	[SerializeField]
	Text healthLabel = null;

	[SerializeField]
	Button playBtn = null;

	[SerializeField]
	Text gameOverLabel = null;

	[SerializeField]
	GameObject player = null;

	[SerializeField]
	Text bestScore = null;

	[SerializeField]
	Text titleLabel = null;

	public void UpdateScore(){
		scoreLabel.text = "Score: " + Player.Instance.Score;
	}

	public void UpdateHealth(){
		healthLabel.text = "Health: " + Player.Instance.Health;
	}
		
	void Start () {
		Player.Instance.hud = this;
	}

	public void GameOver(){
		//hide labels with life and points
		scoreLabel.gameObject.SetActive(false);
		healthLabel.gameObject.SetActive(false);

		//deactivate player
		player.SetActive(false);

		//display "Game Over" label
		gameOverLabel.gameObject.SetActive(true);
		bestScore.gameObject.SetActive (true);
		bestScore.text = "Best Score: " + Player.Instance.BestScore;

		//display restart button
		playBtn.gameObject.SetActive(true);
		titleLabel.gameObject.SetActive(true);
	}

	public void StartGame(){
		//show labels with life and points
		scoreLabel.gameObject.SetActive(true);
		healthLabel.gameObject.SetActive(true);
		Player.Instance.Score = 0;
		Player.Instance.Health = 1000;

		//deactivate player
		player.SetActive(true);

		//display "Game Over" label and best score
		gameOverLabel.gameObject.SetActive(false);
		bestScore.gameObject.SetActive (false);

		//display restart button
		playBtn.gameObject.SetActive(false);
		titleLabel.gameObject.SetActive (false);
	}
}
