using UnityEngine;
using System.Collections;
/*
 * Source Filename: NoStarCrateCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class NoStarCrateCollider : MonoBehaviour {

	[SerializeField]
	GameObject crate = null;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Kunai") {
			Player.Instance.Score += 5;
			crate.gameObject.SetActive (false);
			Destroy (other.gameObject);
		}
	}
}
