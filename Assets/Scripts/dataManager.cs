using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class dataManager
{
    private static int defaultMoney = 700;
    private static int actualMoney;

    static dataManager() {
        actualMoney = PlayerPrefs.GetInt("money", defaultMoney);
    }

    public static int setMoney(int val) {
        PlayerPrefs.SetInt("money", val);
        actualMoney = val;
        return actualMoney;
    }

    public static int addMoney(int val) {
        setMoney(actualMoney + val);
        return actualMoney;
    }

    public static int delMoney(int val) {
        setMoney(actualMoney - val);
        return actualMoney;
    }

    public static int getMoney() {
        return actualMoney;
    }
}
