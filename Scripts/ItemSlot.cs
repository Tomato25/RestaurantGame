using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler{

    public static GameObject selection1;
    public string selection1name;
   
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("slot");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;

            selection1 = eventData.pointerDrag.GetComponent<DragDrop>().gameObject;
            selection1name = eventData.pointerDrag.GetComponent<DragDrop>().gameObject.name;
            PlayerPrefs.SetString("Slot1" ,selection1name);

        }
    }
}
