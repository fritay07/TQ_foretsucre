using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler {

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        // throw new System.NotImplementedException();
    }

    
}
