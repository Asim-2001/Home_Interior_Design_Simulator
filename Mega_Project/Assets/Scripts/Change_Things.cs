using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Things : MonoBehaviour
{
    public GameObject Old_Dinning_Table;
    public GameObject New_Dinning_Table;

    public void ChangeTable()
    {
        Old_Dinning_Table.SetActive(false);
        New_Dinning_Table.SetActive(true);
    }
}
