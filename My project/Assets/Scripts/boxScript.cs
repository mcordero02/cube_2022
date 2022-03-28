using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.
//small change
//another very small change
public class boxScript : MonoBehaviour
{
    public float speed = 5.0f;
    //public float rotationSpeed = 100.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float translation1 = Input.GetAxis("Horizontal") * speed;
        float translation2 = Input.GetAxis("Jump") * speed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        translation1 *= Time.deltaTime;
        translation2 *= Time.deltaTime;


        // Move translation along the object's z-axis
        transform.Translate(translation1, translation2, translation);



        // Rotate around our y-axis
        //ransform.Rotate(0, rotation, 0);
    }
}
