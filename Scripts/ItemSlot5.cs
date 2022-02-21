using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot5 : MonoBehaviour, IDropHandler
{

    public static GameObject selection5;
    public string selection5name;

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;

            selection5 = eventData.pointerDrag.GetComponent<DragDrop>().gameObject;
            selection5name = eventData.pointerDrag.GetComponent<DragDrop>().gameObject.name;
            PlayerPrefs.SetString("Slot5", selection5name);

        }
    }
}

