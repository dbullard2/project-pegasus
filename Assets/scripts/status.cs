using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class status : MonoBehaviour {
    public float hunger;
    public float temperature;


    void Start() {

    }

    void Update() {
    }

    void OnTriggerEnter2D(Collider2D col){
      /*if(col.gameObject.CompareTag("food")){
        col.gameObject.SetActive (false);
      }*/
      Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
