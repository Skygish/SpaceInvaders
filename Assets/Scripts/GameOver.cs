using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour {
	private TextMeshProUGUI gameOver;

    // Start is called before the first frame update
    void Start() {
        gameOver = GetComponent<TextMeshProUGUI>();
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if (PlayerHealth.playerHealth == 0) {
        	Time.timeScale = 0;
        	gameOver.enabled = true;
        }
    }
}
