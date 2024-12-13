using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Private Varibles
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Stat is called before the first frame update - JM
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        
        //This where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //We move the Vehicle Forward here
        // transform.Translate(0,0,1); // this moveds the object forward the object forwards 1 meter 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Time.deltaTime Forces the game to run no matter what how many frames are made
                                                                                      //Currently moving forward 5 m pre second. 

        //Move the vehicle left or right. 
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //Makes the car rotate while turn unlike the line above when turning.
        //This also turns the vehicle
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
      

    }
}
