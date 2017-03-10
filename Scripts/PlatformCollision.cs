using UnityEngine;
using System.Collections;
/*
 * Source Filename: PlatformCollision.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */

/*
	we copied this code from a tutorial in youtube
https://www.youtube.com/watch?v=hrKx5KdG4oA&list=PLX-uZVK_0K_6VXcSajfFbXDXndb6AdBLO&index=12
*/
public class PlatformCollision : MonoBehaviour {

	private PolygonCollider2D playerCollider;

	[SerializeField]
	private BoxCollider2D platformCollider = null;
	[SerializeField]
	private BoxCollider2D platformTrigger = null;

	// Use this for initialization
	void Start () {
	
		playerCollider = GameObject.Find ("Player").GetComponent<PolygonCollider2D> ();
		Physics2D.IgnoreCollision (platformCollider, platformTrigger, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {

			Physics2D.IgnoreCollision (platformCollider, playerCollider, true);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
		
			Physics2D.IgnoreCollision (platformCollider, playerCollider, false);
		}
	}
}
