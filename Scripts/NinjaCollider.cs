using UnityEngine;
using System.Collections;
/*
 * Source Filename: NinjaCollider.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class NinjaCollider : MonoBehaviour {

	[SerializeField]
	Transform spawnPoint = null;

	void Start()
	{
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		
		if (other.gameObject.tag == "Enemy") {
			NinjaController ninja = GetComponent<NinjaController> ();
			Player.Instance.Lives--;
			int count = Player.Instance.Lives;
			if (count <= 0) 
			{
				ninja.Death ();
			}

		} 

		else if (other.gameObject.tag == "KillZone") 
		{
			Player.Instance.Lives--;
			int count1 = Player.Instance.Lives;
			if (count1 > 0) {
				gameObject.transform.position = spawnPoint.position;

			}
			else 
			{
				gameObject.transform.position = spawnPoint.position;
				NinjaController ninja = GetComponent<NinjaController> ();
				ninja.Death ();
			}
		}
	}

}
