using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour {
	public static int playerScore = 0;

	private TextMeshProUGUI scoreText;

	void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
        playerScore = 0;
    }

    // Update is called once per frame
    void Update() {
        scoreText.text = "Score: " + playerScore;
    }
}
