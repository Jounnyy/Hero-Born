using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{
    public class Character
    {
    public string name = "azikra";
    public int exp = 0;
    }

    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
    }
}
