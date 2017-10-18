using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {

	RectTransform _transform;
	public float speed = 300f;
	public RectTransform tubes1;
	public RectTransform tubes2;

	void Awake()
	{
		_transform = transform as RectTransform;
	}

	void Update()
	{
		transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (_transform.anchoredPosition.x <= -749) 
		{
			_transform.anchoredPosition = new Vector2 (749f, 0);
			tubes1.anchoredPosition = new Vector2 (tubes1.anchoredPosition.x, Random.Range (-200, 120));
			tubes2.anchoredPosition = new Vector2 (tubes2.anchoredPosition.x, Random.Range (-200, 120));
		}
	}

}
