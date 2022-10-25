using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {
    private Transform bullet;
    public float speed;
    
    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate() {
        bullet.position += Vector3.down * speed;
        if (bullet.position.y <= -8)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(gameObject);
            PlayerHealth.playerHealth -= 1;
        }
    }
}
