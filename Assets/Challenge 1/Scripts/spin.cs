using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour{
    
    public float spinSpeed = 5.0f;
    private Vector3 axis = new Vector3(0,0,1);

    // Update is called once per frame
    void Update(){
        transform.Rotate(axis * Time.deltaTime * spinSpeed * 10);
    }
}