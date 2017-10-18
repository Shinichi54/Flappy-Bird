using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour {

	public GameObject gameOver;
	public AudioSource Die;
	public AudioSource Hit;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Player") 
		{
			if (!gameOver.activeSelf)
			{
				gameOver.SetActive(true);
			}
			MapMove map1 = GameObject.Find ("Map1").GetComponent<MapMove> ();
			map1.enabled = false;
			MapMove map2 = GameObject.Find ("Map2").GetComponent<MapMove> ();
			map2.enabled = false;

			Rigidbody2D playerRigidbody2D = GameObject.Find ("Player").GetComponent<Rigidbody2D> ();
			Destroy (playerRigidbody2D);
			if (GameSever.getSingleton().isMute == true) {
				Die.mute = GameSever.getSingleton().isMute;
				Hit.mute = GameSever.getSingleton().isMute;
			} 
			else
			{
				Die.Play ();
				Hit.Play ();
			}
		}
	}
}
