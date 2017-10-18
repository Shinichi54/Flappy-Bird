using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour 
{
	public Text score;

	void Update () 
	{
		score.text = GameSever.getSingleton ().score.ToString();
	}
}
