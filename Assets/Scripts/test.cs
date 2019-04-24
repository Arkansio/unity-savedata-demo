using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Money: " + dataManager.getMoney());
        Debug.Log("Increase money: " + dataManager.addMoney(500));
        Debug.Log("Decrease money: " + dataManager.delMoney(1000));
        Debug.Log("Set money: " + dataManager.setMoney(400));
    }
}
