using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class FoodProgressSlot : MonoBehaviour, IDropHandler
{


    public string staff1;
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
    public string foodSliderValue;
    public TextMeshProUGUI foodtext;
    public GameObject avatar1;
    public GameObject avatar2;
    public GameObject avatar3;
    public GameObject avatar4;
    public GameObject avatar5;
    public GameObject avatar6;
    public GameObject avatar7;
    public GameObject avatar8;
    public GameObject avatar9;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("slot");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnFood = true;
            staff1 = eventData.pointerDrag.GetComponent<GameDragAndDrop>().gameObject.name;
            Debug.Log(staff1);



            if (staff1 == "avatar1")
            {

                FoodSkill = Avatar1Skills.foodSkill;
                if (FoodSkill != 0)
                {

                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar1);
                }
            }

            if (staff1 == "Avatar2")
            {

                FoodSkill = Avatar2Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar2);
                }
            }

            if (staff1 == "Avatar3")
            {

                FoodSkill = Avatar3Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar3);
                }
            }

            if (staff1 == "Avatar4")
            {

                FoodSkill = Avatar4Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar4);
                }
            }

            if (staff1 == "Avatar5")
            {

                FoodSkill = Avatar5Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar5);
                }
            }

            if (staff1 == "Avatar6")
            {

                FoodSkill = Avatar6Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar6);
                }
            }

            if (staff1 == "Avatar7")
            {

                FoodSkill = Avatar7Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar7);
                }
            }

            if (staff1 == "Avatar8")
            {

                FoodSkill = Avatar8Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar8);
                }
            }

            if (staff1 == "Avatar9")
            {

                FoodSkill = Avatar9Skills.foodSkill;
                if (FoodSkill != 0)
                {
                    Debug.Log(FoodSkill);
                    food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                    food.value = food.value + FoodSkill;
                    foodSliderValue = food.value.ToString();
                    foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                    foodtext.text = foodSliderValue + "/10";
                    Destroy(avatar9);
                }
            }
        }
    }
}
