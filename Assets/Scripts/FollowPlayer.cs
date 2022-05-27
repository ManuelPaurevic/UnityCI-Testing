using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 7, -10);

    void Start(){
        
    }

    // Update is called once per frame
    void LateUpdate(){
        //Offest the camera to 
        transform.position = player.transform.position + cameraOffset;
    }
}
