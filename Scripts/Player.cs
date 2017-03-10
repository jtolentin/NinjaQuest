using UnityEngine;
using System.Collections;
/*
 * Source Filename: Player.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class Player  {

	private const string key ="HIGH_SCORE";

	private int score = 0;
	private int lives = 3;
	private int highScore = 0;
	private int star = 0;
	private int level = 0;

	public HUDController hud; 

	private static Player _instance = null;
	public static Player Instance
	{
		get
		{
			if (_instance == null) 
			{
				_instance = new Player ();
			}
			return _instance;
		}
	}

	private Player(){

		if (PlayerPrefs.HasKey (key))
		{
			highScore = PlayerPrefs.GetInt (key);
		}
	}

	public int Score 
	{
		get
		{
			return score;
		}
		set
		{
			score = value;
			hud.UpdateScore();
			// trigger UI update
			if (value > highScore) 
			{
				PlayerPrefs.SetInt (key, value);
				highScore = value;
			}
		}
	}
	public int Lives 
	{
		get
		{
			return lives;
		}
		set
		{
			lives = value;
			hud.UpdateLives();
			// trigger UI update
			if (lives <= 0) 
			{
				hud.GameOver ();
			}
		}
	}

	public int Star 
	{
		get
		{
			return star;
		}
		set
		{
			star = value;
			hud.UpdateStars();
		}
	}

	public int Level 
	{
		get
		{
			return level;
		}
		set
		{
			level = value;
			if (level >= 3) 
			{
				hud.Finish ();
			}
		}
	}


	public int HighScore
	{
		get{
			return highScore;
		}
			
	}
}
