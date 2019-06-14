using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    void Start() {

    }

    void FixedUpdate() {
      if(Input.GetKey("right") || Input.GetKey("d")){
        transform.Translate(Vector3.right * Time.deltaTime);
      }

      if(Input.GetKey("left") || Input.GetKey("a")){
        transform.Translate(Vector3.left * Time.deltaTime);
      }
    }
}
