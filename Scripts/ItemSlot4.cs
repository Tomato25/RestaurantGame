using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot4 : MonoBehaviour, IDropHandler
{

    public static GameObject selection4;
    public string selection4name;

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;

            selection4 = eventData.pointerDrag.GetComponent<DragDrop>().gameObject;
            selection4name = eventData.pointerDrag.GetComponent<DragDrop>().gameObject.name;
            PlayerPrefs.SetString("Slot4", selection4name);

        }
    }
}

