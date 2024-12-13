using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3((float)0.0, (float)4.5, (float)-8.39);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update() is called once per frame
    //Late Update() is different because it will happen after the update method happens this remove the jitter with the vehicle/Camera
    void LateUpdate()
    {
        //Offsets the camera behind the player by adding to the player's position 
        transform.position = player.transform.position + offset;
    }
}
