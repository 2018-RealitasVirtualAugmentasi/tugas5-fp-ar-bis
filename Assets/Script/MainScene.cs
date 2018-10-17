using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {

	// Use this for initialization

	public Material mTiger;
	public Material mBunny;
	public Material mSloth;
	public Material mUnicorn;


	void Start () {

		if (TypeMotif.motif == 1) {
			GetComponent<Renderer> ().material = mBunny;
		}
		else if (TypeMotif.motif == 2) {
			GetComponent<Renderer> ().material = mSloth;
		}
		else if (TypeMotif.motif == 3) {
			GetComponent<Renderer> ().material = mTiger;
		}
		else if (TypeMotif.motif == 4) {
			GetComponent<Renderer> ().material = mUnicorn;
		}


	}

	public void BackPressed(){
		SceneManager.LoadScene ("menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
