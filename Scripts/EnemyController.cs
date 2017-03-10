using UnityEngine;
using System.Collections;
/*
 * Source Filename: EnemyController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class EnemyController : MonoBehaviour {

	[SerializeField]
	private LayerMask enemyMask = 0;
	[SerializeField]
	private float speed = 1;


	private Rigidbody2D _body = null;
	private Transform _trans = null;
	private float _width, _height;

	void Start () {

		_body = gameObject.GetComponent<Rigidbody2D> ();
		_trans = this.transform;

		SpriteRenderer sprite = this.GetComponent<SpriteRenderer> ();
		_width = sprite.bounds.extents.x;
		_height= sprite.bounds.extents.y;

	}

	void FixedUpdate () {

		Vector2 lineCastPos = (Vector2)_trans.position -
			(Vector2)_trans.right * _width -
			Vector2.up * _height;

		Debug.DrawLine (lineCastPos, lineCastPos + Vector2.down);

		bool isGrounded = Physics2D.Linecast (lineCastPos, 
			lineCastPos + Vector2.down,
			enemyMask);

		if (!isGrounded) {
			Vector3 currRot = _trans.eulerAngles;
			currRot.y += 180;
			_trans.eulerAngles = currRot;
		}

		Vector2 vel = _body.velocity;
		vel.x = -_trans.right.x * speed;
		_body.velocity = vel;

	}
}

