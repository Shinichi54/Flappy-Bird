using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour {
	public AudioSource Point;

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			GameSever.getSingleton ().score++;
			GameSever.getSingleton ().SetMaxScore ();
			if (GameSever.getSingleton ().isMute == true) {
				Point.mute = GameSever.getSingleton().isMute;
			} else {
				Point.Play ();
			}
		}
	}
}
