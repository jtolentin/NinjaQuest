using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
/*
 * Source Filename: BacktoStartMenu.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class BackToStartMenu : MonoBehaviour {

	[SerializeField]
	GameObject canvas = null;

	public void BacktoMain(){
		SceneManager.LoadScene ("StartMenu");
		Player.Instance.Level = 0;
		canvas.gameObject.SetActive (false);
		Player.Instance.Star = 0;
		Player.Instance.Lives = 3;
		Player.Instance.Score = 0;
		Physics2D.IgnoreLayerCollision (8, 9, false);
	}

}
