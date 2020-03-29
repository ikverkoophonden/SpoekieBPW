using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{
  public GameObject Spookjes; 
  public Transform target;
  public float Speed = 5f;
  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "GoSpook")
    {
        Debug.Log("het werkt");
        Spookjes.SetActive(true);
        StartCoroutine(LerpTransformPositions(Spookjes.transform, target.position, Speed));
     }
   }
   public static IEnumerator LerpTransformPositions(Transform currentTransform, Vector3 targetPosition, float speed)
    {
        if (currentTransform == null) yield return null;
        //The Time
        float time = Time.time;

        //old position
        Vector3 transformOldPosition = currentTransform.position;

        //While loop
        while (currentTransform.position != targetPosition)
        {
            try
            {
                if (currentTransform != null)
                    currentTransform.position = Vector3.MoveTowards(transformOldPosition, targetPosition, (Time.time - time) * speed);
                else
                    break;
            }
            catch(MissingReferenceException)
            {
                break;
            }

            yield return null;

        }

        yield return new WaitForEndOfFrame();
    }
}