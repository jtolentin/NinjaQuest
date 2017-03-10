using UnityEngine;
using System.Collections;
/*
 * Source Filename: HeartCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class HeartCollider : MonoBehaviour {

	[SerializeField]
	GameObject heartAnim = null;

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Player.Instance.Lives += 1;
			Destroy (gameObject);
			GameObject heart = (GameObject)Instantiate (heartAnim);
			heart.transform.position = transform.position;
		}
	}
}
