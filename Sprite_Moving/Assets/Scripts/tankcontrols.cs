using UnityEngine;
using System.Collections.Generic;

public class tankcontrols : MonoBehaviour {

	private Transform tf;
	private Rigidbody2D rb2D;
	public float turnSpeed;
	public float moveSpeed;

	public float force;

	private float angle = 0.0f;

    //starts the code
	void Start()
	{
		tf = GetComponent<Transform>();
        //calls the rigidbody of the sprite
		rb2D = GetComponent<Rigidbody2D>();
	}

    //updates the game when the player interacts with the game
	void Update()
	{
        //when you press down 'A' it turns the player left 
		if (Input.GetKey(KeyCode.A))
			{
				angle += turnSpeed * Time.deltaTime;
                //rotates the player when key is pressed
				tf.rotation = Quaternion.Euler(0, 0, angle);
			}

        //when you press down 'D' it turns the player right
        if (Input.GetKey(KeyCode.D))
			{
                //determines angle and speed of player
				angle -= turnSpeed * Time.deltaTime;
                //rotates the player when the key is pressed
				tf.rotation = Quaternion.Euler(0, 0, angle);
			}

        //when you press down 'W' it moves the player forward
        if (Input.GetKey(KeyCode.W))
			{
                // translates movement of player

                tf.Translate(tf.up * moveSpeed * Time.deltaTime, Space.World);
				//tf.position += (tf.right * moveSpeed * Time.deltaTime);
				//tf.position += (tf.TransformDirection(Vector3.right) * moveSpeed * Trans
			}

        //when you press down 'S' it moves the player back
        if (Input.GetKey(KeyCode.S))
			{
                    //translates movement of player
					tf.Translate(-tf.up * moveSpeed * Time.deltaTime, Space.World);
					//tf.position -= (tf.right * moveSpeed * Time.deltaTime);
					//tf.position -= (tf.TransormDirection(Vector3.right) * moveSpeed * Trans
			}
	}
}