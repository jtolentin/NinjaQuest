using UnityEngine;
using System.Collections;
/*
 * Source Filename: NinjaController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class NinjaController : MonoBehaviour {

	[SerializeField]
	private float force = 1f;
	[SerializeField]
	private float jumpForce =30;
	[SerializeField]
	Transform spawnPoint = null;
	[SerializeField]
	GameObject Kunai = null;
	[SerializeField]
	GameObject Kunai2 = null;
	[SerializeField]
	GameObject kunaiPosition = null;




	private Rigidbody2D _rigidBody = null;
	private Animator _animator = null;
	public float fireRate = 0.5F;
	private float nextFire = 0.0F;

	// Use this for initialization
	void Start () {
	
		_rigidBody = GetComponent<Rigidbody2D> ();
		_animator = GetComponent<Animator> ();
		gameObject.transform.position = spawnPoint.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (!_dead) {
			Vector2 forceVector = new Vector2 (Input.GetAxis ("Horizontal"),
				                     0);

			float jump = Input.GetAxis ("Jump");
			if (jump > 0 && IsGrounded ()) {
				_rigidBody.AddForce (Vector2.up * jumpForce);
			}
			//if (IsGrounded ()) {
				_rigidBody.AddForce (forceVector * force);
			//}
			_animator.SetInteger ("Velocity", (int)(Mathf.Abs(_rigidBody.velocity.x) * 1000));
			if (_rigidBody.velocity.x < 0) {
				gameObject.transform.localScale = new Vector3 (-0.7f, 0.7f, 0.7f);
			} else {
				gameObject.transform.localScale = new Vector3 (0.7f, 0.7f, 0.7f);

			}

			if (Input.GetKeyDown (KeyCode.K) && IsGrounded ()  && Time.time > nextFire) {
				Vector3 scale = transform.localScale;
				nextFire = Time.time + fireRate;
				if (scale.x > 0) {
					_animator.SetTrigger ("Throw");
					GameObject kunai = (GameObject)Instantiate (Kunai);
					kunai.transform.position = kunaiPosition.transform.position;

				}
				if (scale.x < 0) {
					_animator.SetTrigger ("Throw");
					GameObject kunai2 = (GameObject)Instantiate (Kunai2);
					kunai2.transform.position = kunaiPosition.transform.position;

				}
					

			}
			if (Input.GetKeyDown (KeyCode.L) && IsGrounded () ) 
			{

				Vector3 scale = transform.localScale;
				if (scale.x > 0) {
					
					_animator.SetTrigger ("Slash");
					AudioSource asrc = gameObject.GetComponent<AudioSource> ();
					if (asrc != null) {
						asrc.Play();
					}
				}
				if (scale.x < 0) {
					_animator.SetTrigger ("Slash");
					AudioSource asrc = gameObject.GetComponent<AudioSource> ();
					if (asrc != null) {
						asrc.Play();
					}
				}
			}
			_animator.SetBool ("Grounded", IsGrounded ());
		}
	}

	private bool IsGrounded(){

		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer> ();

		RaycastHit2D res = Physics2D.Linecast(
			new Vector2 (gameObject.transform.position.x,
				gameObject.transform.position.y - (sr.bounds.size.y / 2))
			,
			new Vector2(gameObject.transform.position.x,
				gameObject.transform.position.y-(sr.bounds.size.y/2 + 0.4f)));

		Debug.DrawLine (new Vector2 (gameObject.transform.position.x,
			gameObject.transform.position.y - (sr.bounds.size.y / 2)),
			new Vector2 (gameObject.transform.position.x,
				gameObject.transform.position.y - (sr.bounds.size.y / 2+0.4f)));

		/*if(res!=null && res.collider!=null)	
			Debug.Log (res.collider.gameObject.name);*/

		return res.collider != null;

	}
	private bool _dead = false;

	public void Death(){

		_dead = true;
		_animator.SetBool ("Dead", _dead);
		Physics2D.IgnoreLayerCollision (8, 9);

	}

	public void Alive(){

		_animator.SetBool ("Dead", false);

	}		
	private bool _hit = false;
	public void Hit()
	{
		_hit = true;
		_animator.SetBool ("Hit", _hit);

	}

	public void NotHit()
	{
		_hit = false;
		_animator.SetBool ("Hit", _hit);

	}
}
