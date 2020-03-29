using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
        public GameObject paal;
        public Material[] material;
        Renderer rend;

    void Start()
    {
    rend = GetComponent<Renderer>();
    rend.enabled = true;
    //rend.sharedMaterial = material[0];

        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "player")
        {
            paal.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
