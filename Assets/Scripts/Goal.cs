﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UIManager.Instance.debugText("reach goal");
            GameManager.Instance.endLevel();
        }
    }
}
