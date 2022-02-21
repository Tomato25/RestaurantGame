using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class GameDragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    Vector3 defaultPos;
    public bool droppedOnBar;
    public bool droppedOnFood;
    public bool droppedOnCustomer;
    public bool droppedOnDrinks;
    public bool droppedOnSplit;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public float BarSkill;
    public float DrinksSkill;
    public float CustomerSkill;
    public float FoodSkill;
    public Slider progressBar;
    public float progressvalue;
    public Slider drinks;
    public Slider food;
    public Slider customer;
    public Slider bar;
    public TextMeshProUGUI drinkstext;
    public string drinksSliderValue;
    public TextMeshProUGUI foodtext;
    public string barSliderValue;
    public TextMeshProUGUI customertext;
    public string customerSliderValue;
    public TextMeshProUGUI bartext;
    public string foodSliderValue;
    public string selectedStaffname;
    public string staff;
    public string currentStaff;



    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        defaultPos = transform.position;
        
        
    }

    public void Start()
    {
        defaultPos = transform.position;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnBar = false;
        eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnDrinks = false;
        eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnFood = false;
        eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnCustomer = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;


            if (droppedOnDrinks == true && DrinksSkill == 0)
            {
                transform.position = defaultPos;
            }

            if (droppedOnBar == true && BarSkill == 0)
            {
                transform.position = defaultPos;
            }

           

            if (droppedOnCustomer == true && CustomerSkill == 0)
            {
                transform.position = defaultPos;
            }


            if (droppedOnFood == true && FoodSkill == 0)
            {
                transform.position = defaultPos;
            }

           
        


    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("onPointerDown");
    }
}
