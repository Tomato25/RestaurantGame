using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStaffOne : MonoBehaviour
{

    public string slot1;
    public string slot2;
    public string slot3;
    public string slot4;
    public string slot5;
    public string slot6;
    public GameObject staffOne;
    public GameObject staffTwo;
    public GameObject staffThree;
    public GameObject staffFour;
    public GameObject staffFive;
    public GameObject staffSix;
    public GameObject staffSeven;
    public GameObject staffEight;
    public GameObject staffNine;
    // Start is called before the first frame update
    void Start()
    {

        
        slot1 = PlayerPrefs.GetString("Slot1");
        slot2 = PlayerPrefs.GetString("Slot2");
        slot3 = PlayerPrefs.GetString("Slot3");
        slot4 = PlayerPrefs.GetString("Slot4");
        slot5 = PlayerPrefs.GetString("Slot5");
        slot6 = PlayerPrefs.GetString("Slot6");
        Debug.Log(slot1);
        if (slot1  == "avatar1" || slot2 == "avatar1" || slot3 == "avatar1" || slot4 == "avatar1" || slot5 == "avatar1" || slot6 == "avatar1")
        {

            staffOne.SetActive(true);
        }

        if (slot1 == "Avatar2" || slot2 == "Avatar2" || slot3 == "Avatar2" || slot4 == "Avatar2" || slot5 == "Avatar2" || slot6 == "Avatar2")
        {

            staffTwo.SetActive(true);
        }
      
        if (slot1 == "Avatar3" || slot2 == "Avatar3" || slot3 == "Avatar3" || slot4 == "Avatar3" || slot5 == "Avatar3" || slot6 == "Avatar3")
        {

            staffThree.SetActive(true);
        }

        if (slot1 == "Avatar4" || slot2 == "Avatar4" || slot3 == "Avatar4" || slot4 == "Avatar4" || slot5 == "Avatar4" || slot6 == "Avatar4")
        {

            staffFour.SetActive(true);
        }

        if (slot1 == "Avatar5" || slot2 == "Avatar5" || slot3 == "Avatar5" || slot4 == "Avatar5" || slot5 == "Avatar5" || slot6 == "Avatar5")
        {

            staffFive.SetActive(true);
        }

        if (slot1 == "Avatar6" || slot2 == "Avatar6" || slot3 == "Avatar6" || slot4 == "Avatar6" || slot5 == "Avatar6" || slot6 == "Avatar6")
        {

            staffSix.SetActive(true);
        }

        if (slot1 == "Avatar7" || slot2 == "Avatar7" || slot3 == "Avatar7" || slot4 == "Avatar7" || slot5 == "Avatar7" || slot6 == "Avatar7")
        {

            staffSeven.SetActive(true);
        }
        if (slot1 == "Avatar8" || slot2 == "Avatar8" || slot3 == "Avatar8" || slot4 == "Avatar8" || slot5 == "Avatar8" || slot6 == "Avatar8")
        {

            staffEight.SetActive(true);
        }

        if (slot1 == "Avatar9" || slot2 == "Avatar9" || slot3 == "Avatar9" || slot4 == "Avatar9" || slot5 == "Avatar9" || slot6 == "Avatar9")
        {

            staffNine.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
