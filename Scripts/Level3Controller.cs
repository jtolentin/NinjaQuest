using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
 * Source Filename: Level3Controller.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class Level3Controller : MonoBehaviour {

	[SerializeField]
	Text highscore = null;
	[SerializeField]
	Text yourScore = null;


	// Use this for initialization
	void Start () {
	
		highscore.text = "HighScore: " + Player.Instance.HighScore;
		yourScore.text = "Your Score: " + Player.Instance.Score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
