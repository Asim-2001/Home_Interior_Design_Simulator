using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ColorPanel;
    public GameObject ColorChange;
    public GameObject Table1;
   // public GameObject Table2;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ColorPanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ColorChange.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           Table1.SetActive(false);
        } 
        if (Input.GetKeyDown(KeyCode.N))
        {
           Table1.SetActive(true);
        }
    }
    
    public void CloseTexture()
    {
        ColorPanel.SetActive(false);
    }
    public void CloseColor()
    {
        ColorChange.SetActive(false);
    }
   
}
