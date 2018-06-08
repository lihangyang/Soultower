using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loadscene : MonoBehaviour {

    public string NextLvscene;
    //public string NextLvname;
	// Use this for initialization
	void Start () {
      
	}

    // Update is called once per frame

    public void Client()
    {
        //Debug.Log("jianting");
        SceneManager.LoadScene(NextLvscene);
    }
}
