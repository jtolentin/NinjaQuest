using UnityEngine;
using System.Collections;
/*
 * Source Filename: CoinCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class CoinCollider : MonoBehaviour {

	[SerializeField]
	GameObject coinAnim = null;

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Player.Instance.Score += 50;
			Destroy (gameObject);
			GameObject coin = (GameObject)Instantiate (coinAnim);
			coin.transform.position = transform.position;
		}
	}
}
