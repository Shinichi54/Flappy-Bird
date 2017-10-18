using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D _rigidbody;
	public float speed = 300;
	public AudioSource Wing;
	public AudioSource Swooshing;

	void Start () 
	{
		_rigidbody = GetComponent<Rigidbody2D> ();
		this.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (GameSever.getSingleton ().PlayerRadius*2, GameSever.getSingleton ().PlayerRadius*2);
		this.gameObject.GetComponent<CircleCollider2D>().radius = GameSever.getSingleton ().PlayerRadius;

	}

	void Update () 
	{
		if(_rigidbody == null){
			return;
		}
		if (Input.GetMouseButtonDown (0)) 
		{
			_rigidbody.velocity = new Vector2 (0, speed);
			if (GameSever.getSingleton ().isMute == true) {
				Wing.mute = GameSever.getSingleton().isMute;
				Swooshing.mute = GameSever.getSingleton().isMute;
			} else {
				Wing.Play ();
				Swooshing.Play();
			}
		}
		if (_rigidbody.velocity.y > 0)
		{
			transform.eulerAngles = new Vector3 (0, 0, 60f);
		}
		else
		{
			transform.eulerAngles = new Vector3 (0, 0, -60f);
		}
	}
}
