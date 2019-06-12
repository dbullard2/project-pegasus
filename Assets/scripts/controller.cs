using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    void Start() {

    }

    void FixedUpdate() {
      if(Input.GetKey("right")){
        Debug.Log("hi");
        transform.Translate(Vector3.right * Time.deltaTime);
      }

      if(Input.GetKey("left")){
        Debug.Log("bye");
        transform.Translate(Vector3.left * Time.deltaTime);
      }
    }
}
