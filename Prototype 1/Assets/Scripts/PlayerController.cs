using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Stat is called before the first frame update - JM
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        //Moves the Vehicle Forward
        // transform.Translate(0,0,1); // this moveds the object forward the object forwards 1 meter 
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //Time.deltaTime Forces the game to run no matter what how many frames are made
    }
}
