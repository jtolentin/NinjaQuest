using UnityEngine;
using System.Collections;
/*
 * Source Filename: CrateCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class CrateCollider : MonoBehaviour {

	[SerializeField]
	GameObject star = null;
	[SerializeField]
	GameObject crate = null;
	// Use this for initialization
	void Start () {


			star.gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Kunai") {
			Player.Instance.Score += 5;
			Destroy (other.gameObject);
			crate.gameObject.SetActive (false);
			star.gameObject.SetActive (true);
		}
	}
}
