using UnityEngine;
using System.Collections;
/*
 * Source Filename: CameraFollow.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class CameraFollow : MonoBehaviour {


	[SerializeField]
	Transform target = null;
	[SerializeField]
	private float MaxBorderX = 0;
	[SerializeField]
	private float MinBorderX = 0;
	[SerializeField]
	private float MaxBorderY = 0;
	[SerializeField]
	private float MinBorderY = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.position = new Vector3(Mathf.Clamp(target.position.x,MinBorderX,MaxBorderX),Mathf.Clamp(target.position.y,MinBorderY,MaxBorderY),transform.position.z);
	}
}
