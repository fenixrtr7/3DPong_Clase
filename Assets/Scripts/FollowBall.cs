using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

    public Transform ball;
    public float speed;
	// 0.1 facil 0.2 normal 0.3 dificil
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (ball.GetComponent<BowlBehaviour>().gameStarted)
        {
            if(transform.position.y < ball.position.y)
            {
                transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + speed, -2.28f, 3.57f), transform.position.z);
            }else if (transform.position.y > ball.position.y)
            {
                transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - speed, -2.28f, 3.57f), transform.position.z);
            }
        }
	}
}
