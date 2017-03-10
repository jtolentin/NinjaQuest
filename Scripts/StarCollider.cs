using UnityEngine;
using System.Collections;
/*
 * Source Filename: StarCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class StarCollider : MonoBehaviour {

	[SerializeField]
	GameObject starAnim = null;
		
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Player.Instance.Star++;
			gameObject.SetActive (false);
			GameObject star = (GameObject)Instantiate (starAnim);
			star.transform.position = transform.position;
			AudioSource asrc = gameObject.GetComponent<AudioSource> ();
			if (asrc != null) {
				asrc.Play();
			}
		}

	}
}
