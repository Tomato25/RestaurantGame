using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot2 : MonoBehaviour, IDropHandler
{

    public static GameObject selection2;
    public string selection2name;

    public void OnDrop(PointerEventData eventData)
    {
        
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;

            selection2 = eventData.pointerDrag.GetComponent<DragDrop>().gameObject;
            selection2name = eventData.pointerDrag.GetComponent<DragDrop>().gameObject.name;
            PlayerPrefs.SetString("Slot2", selection2name);

        }
    }
}

