using UnityEngine;
using System.Collections;
/*
 * Source Filename: Killzone.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class Killzone : MonoBehaviour {

	[SerializeField]
	Transform spawnPoint = null;

	public void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals ("Player")) {
			Player.Instance.Lives--;
			if (Player.Instance.Lives > 0) {
				other.gameObject.transform.position = spawnPoint.position;
			} 

		}
	}
}
