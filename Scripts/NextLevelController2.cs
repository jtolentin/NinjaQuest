using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Source Filename: NextLevelController2.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class NextLevelController2 : MonoBehaviour {

	private int count = 0;


	void OnTriggerEnter2D(Collider2D other)
	{
		count = count + Player.Instance.Star;
		if(count >= 3)
		{
			Player.Instance.Level += 1;
			SceneManager.LoadScene (Player.Instance.Level);
			Player.Instance.Star = 0;
		}
	}
}
