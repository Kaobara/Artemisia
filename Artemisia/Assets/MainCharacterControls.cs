using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterControls : MonoBehaviour
{
    [SerializeField] float movement = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)) {
            movement = 0.3f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)) {
            movement = 0.1f;
        }
        if(Input.GetKey(KeyCode.W)) {
            transform.Translate(0,movement,0);
        } 
        if(Input.GetKey(KeyCode.A)) {
            transform.Translate(-movement,0,0);
        }
        if(Input.GetKey(KeyCode.S)) {
            transform.Translate(0,-movement,0);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.Translate(movement,0,0);
        }
    }
}
