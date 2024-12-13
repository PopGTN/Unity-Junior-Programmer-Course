using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    //Note: tutorial said to have this private not public
    public Vector3 offset = new Vector3((float)0.0, (float)4, (float)-7.0);
    public Vector3 coffset = new Vector3((float)0.0, (float)4, (float)-7.0);

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
