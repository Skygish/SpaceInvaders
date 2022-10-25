using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour {

	private Transform enemyHolder;
	public float speed;

	public GameObject shot;
	public TextMeshProUGUI winText;
	public float fireRate = 0.9f;
    
    void Start() {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    void MoveEnemy() {
    	enemyHolder.position += Vector3.right * speed;

    	foreach (Transform enemy in enemyHolder) {
    		if (enemy.position.x < -11.5 || enemy.position.x > 11.5) {
    			speed = -speed * 1.1f;
    			enemyHolder.position += Vector3.down * 0.5f;
    			return;
    		}

    		if (Random.value > fireRate) {
    			Instantiate(shot, enemy.position, enemy.rotation);
    		}
    	}
    }

    void Update() {
    	if (enemyHolder.childCount == 0) {
    		winText.enabled = true;
    	}
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(gameObject);
            PlayerHealth.playerHealth -= 1;
        }
    }
}
