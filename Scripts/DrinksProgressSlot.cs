using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DrinksProgressSlot : MonoBehaviour, IDropHandler
{

    public string staff;
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
    public bool droppedOnDrinks;
    Vector3 defaultPos;
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

        defaultPos = transform.position;

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnDrinks = true;
            staff = eventData.pointerDrag.GetComponent<GameDragAndDrop>().gameObject.name;
            Debug.Log(staff);

            if (staff == "Avatar3")
            {

                DrinksSkill = Avatar3Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar3);

                }
            }
                if (staff == "avatar1")
                {

                    DrinksSkill = Avatar1Skills.drinksSkill;
                    if (DrinksSkill != 0)
                    {

                        Debug.Log(DrinksSkill);
                        drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                        drinks.value = drinks.value + DrinksSkill;
                        drinksSliderValue = drinks.value.ToString();
                        drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                        drinkstext.text = drinksSliderValue + "/10";
                        Destroy(avatar1);
                    }
                }

            

            if (staff == "Avatar2")
            {

                DrinksSkill = Avatar2Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar2);
                }
            }

            if (staff == "Avatar4")
            {

                DrinksSkill = Avatar4Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar4);
                }
            }


            if (staff == "Avatar5")
            {

                DrinksSkill = Avatar5Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar5);
                }
            }


            if (staff == "Avatar6")
            {

                DrinksSkill = Avatar6Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar6);
                }
            }


            if (staff == "Avatar7")
            {

                DrinksSkill = Avatar7Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar7);
                }
            }

            if (staff == "Avatar8")
            {

                DrinksSkill = Avatar8Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar8);
                }
            }


            if (staff == "Avatar9")
            {

                DrinksSkill = Avatar9Skills.drinksSkill;
                if (DrinksSkill != 0)
                {
                    Debug.Log(DrinksSkill);
                    drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                    drinks.value = drinks.value + DrinksSkill;
                    drinksSliderValue = drinks.value.ToString();
                    drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                    drinkstext.text = drinksSliderValue + "/10";
                    Destroy(avatar9);
                }
            }




        }
    }
}
