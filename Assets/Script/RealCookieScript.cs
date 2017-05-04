﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RealCookieScript : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Destroy(gameObject, 5.0f); // make cookie disappear if not clicked after 10secs
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown()
    {
        GameObject score = GameObject.Find("Score");
        score.SendMessage("AddScore");
        Destroy(gameObject);
    }
}
