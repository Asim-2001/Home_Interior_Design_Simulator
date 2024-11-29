using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Function : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;
    public GameObject Object6;
    public GameObject close;
    public GameObject function_Pannel;

    public void obj1()
    {
        Object1.SetActive(true);
    }
    public void obj2()
    {
        Object2.SetActive(true);
    }
    public void obj3()
    {
        Object3.SetActive(true);
    }
    public void obj4()
    {
        Object4.SetActive(true);
    }
    public void obj5()
    {
        Object5.SetActive(true);
    }
    public void obj6()
    {

        Object6.SetActive(true);
    }
    public void Close_Window()
    {
        close.SetActive(false);
        function_Pannel.SetActive(true);
    }
}
