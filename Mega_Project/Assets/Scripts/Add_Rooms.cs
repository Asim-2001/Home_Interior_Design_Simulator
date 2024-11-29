using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Rooms : MonoBehaviour
{
    public GameObject Room;
    public void OnRoom()
    {
        Room.SetActive(true);
    }
    public void OfRoom()
    {
        Room.SetActive(false);
    }
}
