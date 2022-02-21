using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CustomerProgressSlot : MonoBehaviour, IDropHandler
{

    public string staff4;
    public float CustomerSkill;
    public TextMeshProUGUI customertext;
    public string customerSliderValue;
    public Slider customer;
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
            eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnCustomer = true;
            staff4 = eventData.pointerDrag.GetComponent<GameDragAndDrop>().gameObject.name;
            Debug.Log(staff4);

            if (staff4 == "avatar1")
            {
                CustomerSkill = Avatar1Skills.customerSkill;

                if (CustomerSkill != 0)
                {
                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar1);
                }
            }

            if (staff4 == "Avatar2")
            {
                CustomerSkill = Avatar2Skills.customerSkill;
                if (CustomerSkill != 0)
                {

                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar2);
                }
            }

            if (staff4 == "Avatar3")
            {
                CustomerSkill = Avatar3Skills.customerSkill;
                if (CustomerSkill != 0)
                {

                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar3);
                }
            }

            if (staff4 == "Avatar4")
            {
                CustomerSkill = Avatar4Skills.customerSkill;

                if (CustomerSkill != 0)
                {
                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar4);
                }
            }

            if (staff4 == "Avatar5")
            {
                CustomerSkill = Avatar5Skills.customerSkill;

                if (CustomerSkill != 0)
                {
                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar5);
                }
            }

            if (staff4 == "Avatar6")
            {
                CustomerSkill = Avatar6Skills.customerSkill;
                if (CustomerSkill != 0)
                {

                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar6);
                }
            }

            if (staff4 == "Avatar7")
            {
                CustomerSkill = Avatar7Skills.customerSkill;
                if (CustomerSkill != 0)
                {

                    customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                    customer.value = customer.value + CustomerSkill;
                    customerSliderValue = customer.value.ToString();
                    customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                    customertext.text = customerSliderValue + "/10";
                    Destroy(avatar7);
                }
            }

            if (staff4 == "Avatar8")


                CustomerSkill = Avatar8Skills.customerSkill;

            if (CustomerSkill != 0)
            {
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";
                Destroy(avatar8);
            }
        }

            if (staff4 == "Avatar9")
            {
                CustomerSkill = Avatar9Skills.customerSkill;

            if (CustomerSkill != 0)
            {
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";
                Destroy(avatar9);
            }
        }

    }


}


