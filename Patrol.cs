using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Patrol : MonoBehaviour
{
    public float speed = 3;
    public bool goLeft = true;
    public Transform left;
    public Transform right;
    private void Update()
    {
        if (goLeft == true)
        {
            transform.Translate(Vector2.left * (speed * Time.deltaTime));
        }
        if (goLeft == false)
        {
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        }
        if (transform.position.x < left.position.x)
        {
            goLeft = false;
        }
        if (transform.position.x > right.position.x)
        {
            goLeft = true;
        }
    }
}