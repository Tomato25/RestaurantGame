using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrinksProgressSlot3 : MonoBehaviour, IDropHandler
{


    public string staff3;


    public void OnDrop(PointerEventData eventData)
    {

        staff3 = eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().gameObject.name;

        if (eventData.pointerDrag != null &&  staff3 == "Avatar3")
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().droppedOnDrinks = true;

        }



    }
}

