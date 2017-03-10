using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Source Filename: NextLevelController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class NextLevelController : MonoBehaviour {

	[SerializeField]
	Canvas canvas = null;

	private int count = 0;
	private int level = 0;

	void OnTriggerEnter2D(Collider2D other)
	{
		level = Player.Instance.Level;
		if (level < 3 && level >= 1) {
			DontDestroyOnLoad (canvas);
		} 
		count = count + Player.Instance.Star;
		if(count >= 3)
		{
				Player.Instance.Level += 1;
				SceneManager.LoadScene (Player.Instance.Level);
				Player.Instance.Star = 0;
		}
	}
}
