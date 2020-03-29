using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpook : MonoBehaviour
{
  public GameObject Spookjes;     
  
  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "GoSpook")
    {
        Spookjes.SetActive(true);
     }
   }
 }