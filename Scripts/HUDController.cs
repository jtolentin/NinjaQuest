using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Source Filename: HUDController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */

public class HUDController : MonoBehaviour {


	[SerializeField]
	Text score = null;
	[SerializeField]
	Image scoreImage = null;
	[SerializeField]
	Text lives = null;
	[SerializeField]
	Image livesImage = null;
	[SerializeField]
	Image gameover = null;
	[SerializeField]
	Text highscore = null;
	[SerializeField]
	Button restartButton = null;
	[SerializeField]
	Text stars = null;
	[SerializeField]
	Image starsImage = null;
	[SerializeField]
	Text yourScore = null;


	// Use this for initialization
	void Start () 
	{
		Player.Instance.hud = this;
		RestartGame ();

	}

	// Update is called once per frame
	void Update () {

	}

	public void UpdateScore()
	{

		score.text = "Score: " + Player.Instance.Score;
	}

	public void UpdateLives()
	{
		lives.text = " X " + Player.Instance.Lives;

	}

	public void UpdateStars()
	{
		stars.text = " X " + Player.Instance.Star;
	}

	public void GameOver()
	{
		lives.gameObject.SetActive (false);
		score.gameObject.SetActive (false);
		scoreImage.gameObject.SetActive (false);
		stars.gameObject.SetActive (false);
		starsImage.gameObject.SetActive (false);
		livesImage.gameObject.SetActive (false);
		highscore.text = "HighScore: " + Player.Instance.HighScore;
		yourScore.text = "Your Score: " + Player.Instance.Score;
		yourScore.gameObject.SetActive (true);
		highscore.gameObject.SetActive (true);
		gameover.gameObject.SetActive (true);
		restartButton.gameObject.SetActive (true);


	}

	public void RestartGame()
	{
		score.gameObject.SetActive (true);
		scoreImage.gameObject.SetActive (true);
		lives.gameObject.SetActive (true);
		stars.gameObject.SetActive (true);
		starsImage.gameObject.SetActive (true);
		livesImage.gameObject.SetActive (true);
		//NinjaController ninja = GetComponent<NinjaController> ();
		//ninja.Alive ();
		Physics2D.IgnoreLayerCollision (8, 9,false);
		yourScore.gameObject.SetActive (false);
		highscore.gameObject.SetActive (false);
		gameover.gameObject.SetActive (false);
		restartButton.gameObject.SetActive (false);
	}

	public void Finish()
	{
		score.gameObject.SetActive (false);
		lives.gameObject.SetActive (false);
		stars.gameObject.SetActive (false);
		starsImage.gameObject.SetActive (false);
		livesImage.gameObject.SetActive (false);
		scoreImage.gameObject.SetActive (false);
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Player.Instance.Score = 0;
		Player.Instance.Lives = 3;
		Player.Instance.Star = 0;
	}
}
