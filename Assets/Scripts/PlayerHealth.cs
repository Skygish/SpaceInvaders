using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour {
	public static int playerHealth = 3;

	private TextMeshProUGUI healthText;

	void Start() {
        healthText = GetComponent<TextMeshProUGUI>();
        playerHealth = 3;
    }

    void Update() {
        healthText.text = "Health: " + playerHealth;
    }
}
