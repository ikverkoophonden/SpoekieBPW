﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneEnter : MonoBehaviour
{
      
  public GameObject thePlayer;
  public GameObject cutsceneCam;

  void OnTriggerEnter(Collider other)
  {
    this.gameObject.GetComponent<BoxCollider>().enabled = false;
    cutsceneCam.SetActive(true);
    thePlayer.SetActive(false);
    StartCoroutine(FinishCut());
  }
        IEnumerator FinishCut() 
        {
            yield return new WaitForSeconds(22);
           thePlayer.SetActive(true);
           cutsceneCam.SetActive(false);
		}
   
}
