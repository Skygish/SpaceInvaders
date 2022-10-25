using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    void Update() {
        if (Input.GetKey("r")) {
        	SceneManager.LoadScene("SampleScene");
        	Time.timeScale = 1;
        }
    }
}
