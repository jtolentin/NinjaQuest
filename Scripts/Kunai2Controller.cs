using UnityEngine;
using System.Collections;
/*
 * Source Filename: Kunai2Controller.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class Kunai2Controller : MonoBehaviour {

	[SerializeField]
	private float speed = 0;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		_currentPosition = transform.position;
		//computes the laser's new position
		_currentPosition = new Vector2(_currentPosition.x - speed, _currentPosition.y);
		transform.position = _currentPosition;
		Vector2 checkBounds = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		if (_currentPosition.x > checkBounds.x) 
		{
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			Player.Instance.Score += 10;
		}
	}

}
