using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeMaterial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BunnyClick(){
		TypeMotif.motif = 1;
		SceneManager.LoadScene ("tesFP");
	}

	public void SlothClick(){
		TypeMotif.motif = 2;
		SceneManager.LoadScene ("tesFP");
	}

	public void TestClick(){
		SceneManager.LoadScene ("tesFP");
	}

	public void TigerClick(){
		TypeMotif.motif = 3;
		SceneManager.LoadScene ("tesFP");
	}

	public void UnicornClick(){
		TypeMotif.motif = 4;
		SceneManager.LoadScene ("tesFP");
	}



}
