using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed;

    public Rigidbody2D rb;

    public bool launched = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !launched)
        {
            Launch();
        }
    }

    private void Launch()
    {
        launched = true;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x, y).normalized * speed;
    }

    public void Reset()
    {
        launched = false;
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "PlayerGoal") {
            LevelManager.instance.Scored(Scorer.AI);
        } else if (other.tag == "AIGoal") {
            LevelManager.instance.Scored(Scorer.Player);
        }

    }
}