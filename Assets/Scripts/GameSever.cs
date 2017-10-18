using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSever 
{
	private static GameSever _instance;
	public static GameSever getSingleton()
	{
		if (_instance == null) 
		{
			_instance = new GameSever ();
		}	
		return _instance;
	}
	private GameSever()
	{
		score = 0;
		maxscore = 0;
		isMute = false;
		PlayerRadius = 50;
	}
	public void SetMaxScore()
	{
		if(score >= maxscore)
		{
			maxscore = score;
		}
	}

	public void Reset()
	{
		score = 0;
	}

	public float score;
	public float maxscore;
	public bool isMute;
	public int PlayerRadius;
}
