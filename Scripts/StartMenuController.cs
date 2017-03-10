using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Source Filename: StartMenuController.cs
 * Group Name: Group 11
 * Members : Jhun Kyle Tolentino - 100955026
 * 			 Roderick Rodelas - 100978575
 *      	 Jomaine Lyka Obial - 100923787
 * 			 Maylin Morales Diaz - 100915710
 * */
public class StartMenuController : MonoBehaviour {
	
	[SerializeField]
	Image title = null;
	[SerializeField]
	Button start = null;
	[SerializeField]
	Button controls = null;
	[SerializeField]
	Button backtoMain = null;
	[SerializeField]
	Text controlsText = null;
	 

	void Start()
	{
		Player.Instance.Level += 1;
		BackToMain ();
	}
	public void StartScene()
	{
		SceneManager.LoadScene (Player.Instance.Level);	

	}

	public void Controls()
	{
		title.gameObject.SetActive (false);
		start.gameObject.SetActive (false);
		controls.gameObject.SetActive (false);
		backtoMain.gameObject.SetActive (true);
		controlsText.gameObject.SetActive (true);
	}

	public void BackToMain()
	{
		title.gameObject.SetActive (true);
		start.gameObject.SetActive (true);
		controls.gameObject.SetActive (true);
		backtoMain.gameObject.SetActive (false);
		controlsText.gameObject.SetActive (false);
	}
		
}
