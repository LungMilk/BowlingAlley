using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidB;
    public float force;
    Vector2 direction;

    public float rotateSpeed = -500;

    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

        rigidB.AddForce(force * direction * Time.deltaTime);

        //this line makes it rotate yippie
        //how does it rotate with the arrow keys
        rigidB.MoveRotation(rigidB.rotation + rotateSpeed * direction.x * Time.deltaTime);
    }
}
