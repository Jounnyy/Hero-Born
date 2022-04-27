using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject directionLight;
    // private Transform camTransform;
    private Transform lightTransform;
    void Start()
    {
        /*Weapon huntingBow = new Weapon("Hunting Bow", 105);

        Paladin knight = new Paladin("Jarod", huntingBow);
        knight.PrintStatsInfo();
       
       Weapon warBow = huntingBow;
       warBow.name =  "Heacy Bow";
       warBow.damage =  124; 

       huntingBow.PrintWeaponStats();
       warBow.PrintWeaponStats();*/

        directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

}