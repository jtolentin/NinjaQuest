using UnityEngine;
using System.Collections;
/*
 * Source Filename: DoorController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class DoorController : MonoBehaviour {

	[SerializeField]
	private float closeDelay = 2f; 

	private bool isOpen = false;
	[SerializeField]
	private float CLOSED = 18.4f;
	[SerializeField]
	private float OPEN = 10.3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == "Player") {
			if (Player.Instance.Star == 3) 
			{
				StartCoroutine ("Open");
			}
		}
	}

	private IEnumerator Open(){
	
		if (!isOpen) {
		
			isOpen = true;
			for (float p = CLOSED; p >= OPEN; p = p - 0.1f) {
				gameObject.transform.position = new Vector2 (
					gameObject.transform.position.x, p);
				yield return new WaitForSeconds(0.1f);
			}
			yield return new WaitForSeconds (closeDelay);
			StartCoroutine ("Close");
		}
	}

	private IEnumerator Close(){

		for (float p = OPEN; p < CLOSED; p = p + 0.1f) {
			gameObject.transform.position = new Vector2 (
				gameObject.transform.position.x, p);
			yield return new WaitForSeconds(0.1f);
		}

		isOpen = false;
	}

}
