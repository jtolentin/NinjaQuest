using UnityEngine;
using System.Collections;
/*
 * Source Filename: EnemyCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class EnemyCollider : MonoBehaviour {

	[SerializeField]
	GameObject Smoke = null;
	[SerializeField]
	GameObject Coin = null;


	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Kunai")
		{
			GameObject coin = (GameObject)Instantiate (Coin);
			coin.transform.position = transform.position;
			GameObject smoke = (GameObject)Instantiate (Smoke);
			smoke.transform.position = transform.position;

		}
	}
}
