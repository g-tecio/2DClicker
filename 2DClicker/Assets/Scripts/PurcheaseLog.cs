﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurcheaseLog : MonoBehaviour {

    public GameObject AutoCookie;

    public void StartAutoCookie (){
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBaker += 1;
    }
}
