using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;

public class rotacion : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float i = 0;
    //Detect current clicks on the GameObject (the one with the script attached)
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        Debug.Log(name + "Game Object Click in Progress");

        i++;
        if (i == 1)
        {
            StartCoroutine(reseti());
        }
        if (i == 2)
        {
            transform.Rotate(0f, 0f, 30f);
            i = 0;
        }

    }

    IEnumerator reseti()
    {

        yield return new WaitForSeconds(0.5f);

        i = 0;
        Debug.Log("--i se reinicio--");
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)

    {

        Debug.Log(name + "No longer being clicked");
        
    }
}
