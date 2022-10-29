using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    private Transform bullet;
    public float speed;
    
    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate() {
        bullet.position += Vector3.up * speed;
        if (bullet.position.y >= 8)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy" || other.tag == "EnemyBullet") {
            Destroy(other.gameObject);
            Destroy(gameObject);
            if (other.tag == "Enemy") {
                PlayerScore.playerScore += 10;
            }
        }
    }
}
