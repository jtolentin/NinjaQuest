using UnityEngine;
using System.Collections;
/*
 * Source Filename: PlatformController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class PlatformController : MonoBehaviour {

	[SerializeField]
	private float length = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, length), transform.position.z);
	}
}
