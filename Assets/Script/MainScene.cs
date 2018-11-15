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

	public Material mBurger;
	public Material mSpongebob;
	public Material mMonster;
	public Material mPattrick;
	public Material mBear;
	public Material mPanda;


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
		else if (TypeMotif.motif == 5) {
			GetComponent<Renderer> ().material = mBurger;
		}
		else if (TypeMotif.motif == 7) {
			GetComponent<Renderer> ().material = mSpongebob;
		}
		else if (TypeMotif.motif == 8) {
			GetComponent<Renderer> ().material = mMonster;
		}
		else if (TypeMotif.motif == 9) {
			GetComponent<Renderer> ().material = mPattrick;
		}
		else if (TypeMotif.motif == 10) {
			GetComponent<Renderer> ().material = mBear;
		}
		else if (TypeMotif.motif == 11) {
			GetComponent<Renderer> ().material = mPanda;
		}


	}

	public void BackPressed(){
		SceneManager.LoadScene ("menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
