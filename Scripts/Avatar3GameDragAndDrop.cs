using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Avatar3GameDragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
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
        eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().droppedOnBar = false;
        eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().droppedOnDrinks = false;
        eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().droppedOnFood = false;
        eventData.pointerDrag.GetComponent<Avatar3GameDragAndDrop>().droppedOnCustomer = false;

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


        if (droppedOnBar == true)
        {
            BarSkill = Avatar3Skills.barSkill;
            Debug.Log(BarSkill);
            bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
            bar.value = bar.value + BarSkill;
            barSliderValue = bar.value.ToString();
            bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
            bartext.text = barSliderValue + "/10";
        }

        if (droppedOnBar == true && BarSkill == 0)
        {
            transform.position = defaultPos;
        }


        if (droppedOnCustomer == true)
        {
            CustomerSkill = Avatar3Skills.customerSkill;

            Debug.Log(BarSkill);
            customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
            customer.value = customer.value + CustomerSkill;
            customerSliderValue = customer.value.ToString();
            customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
            customertext.text = customerSliderValue + "/10";
        }

        if (droppedOnCustomer == true && CustomerSkill == 0)
        {
            transform.position = defaultPos;
        }

        if (droppedOnFood == true)
        {

            FoodSkill = Avatar3Skills.foodSkill;
            Debug.Log(FoodSkill);
            food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
            food.value = food.value + FoodSkill;
            foodSliderValue = food.value.ToString();
            foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
            foodtext.text = foodSliderValue + "/10";


        }

        if (droppedOnFood == true && FoodSkill == 0)
        {
            transform.position = defaultPos;
        }

        if (droppedOnSplit == true)
        {

            FoodSkill = Avatar3Skills.foodSkill / 2;
            Debug.Log(FoodSkill);
            food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
            food.value = food.value + FoodSkill;
            foodSliderValue = food.value.ToString();
            foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
            foodtext.text = foodSliderValue + "/10";

            CustomerSkill = Avatar3Skills.customerSkill / 2;

            Debug.Log(BarSkill);
            customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
            customer.value = customer.value + CustomerSkill;
            customerSliderValue = customer.value.ToString();
            customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
            customertext.text = customerSliderValue + "/10";

            DrinksSkill = Avatar3Skills.drinksSkill / 2;
            Debug.Log(DrinksSkill);
            drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
            drinks.value = drinks.value + DrinksSkill;
            drinksSliderValue = drinks.value.ToString();
            drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
            drinkstext.text = drinksSliderValue + "/10";

            BarSkill = Avatar3Skills.barSkill / 2;
            Debug.Log(BarSkill);
            bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
            bar.value = bar.value + BarSkill;
            barSliderValue = bar.value.ToString();
            bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
            bartext.text = barSliderValue + "/10";

        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("onPointerDown");
    }
}
