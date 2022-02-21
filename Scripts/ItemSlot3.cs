using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot3 : MonoBehaviour, IDropHandler
{

    public static GameObject selection3;
    public string selection3name;

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;

            selection3 = eventData.pointerDrag.GetComponent<DragDrop>().gameObject;
            selection3name = eventData.pointerDrag.GetComponent<DragDrop>().gameObject.name;
            PlayerPrefs.SetString("Slot3", selection3name);

        }
    }
}

