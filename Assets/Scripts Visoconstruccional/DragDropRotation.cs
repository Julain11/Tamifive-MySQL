using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDropRotation : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler
{
        public void OnBeginDrag(PointerEventData eventData)
    {
       Debug.Log("OnBeginDrag");
    }
        public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position= Input.mousePosition;
        
    }
        public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        
        
    }
     public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (name=="Image (7)")
        {
            transform.Rotate(0f, 0f, Input.GetAxis("Horizontal"));
        }

        
    }
}
