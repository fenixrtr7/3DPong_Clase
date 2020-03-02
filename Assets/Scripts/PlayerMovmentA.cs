using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentA : MonoBehaviour
{

    public float speed = 6;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePos.y, -2.28f, 3.57f), transform.position.z);


        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     transform.position += Vector3.up * speed * Time.deltaTime;
        // }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     transform.position += Vector3.down * speed * Time.deltaTime;
        // }

        float yMove = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0f, yMove, 0f);

        // Initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;

        // Now we can manipulte it to clamp the y element
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -2.28f, 3.57f);

        // Re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }
}
