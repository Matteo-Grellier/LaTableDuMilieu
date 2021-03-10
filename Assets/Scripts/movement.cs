﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //Reference
    GameObject KBOne;
    GameObject KBTwo;
    GameObject KWOne;
    GameObject KWTwo;

    GameObject Board;

    //Coordinates
    Vector2 kbOPos = new Vector2();
    Vector2 kbTPos = new Vector2();
    Vector2 kwOPos = new Vector2();
    Vector2 kwTPos = new Vector2();

    //others
    //string nameOfElement;

    // Start is called before the first frame update
    void Start()
    {
        /*KBOne = GameObject.Find("Knight_b1");
        KBTwo = GameObject.Find("Knight_b2");
        KWOne = GameObject.Find("Knight_w1");
        KWTwo = GameObject.Find("Knight_w2");*/

        Board = GameObject.Find("Board");
    }

    // Update is called once per frame
    void Update()
    {
        /*kbOPos = KBOne.transform.position;
        kbTPos = KBTwo.transform.position;
        kwOPos = KWOne.transform.position;
        kwTPos = KWTwo.transform.position;*/
            
    }

    void OnMouseDown()
    {
        //Debug.Log("quand je OnMousDown " + kbOPos);

        // voir si il faut mettre le nom de l'élément cliquer dans une variable et la récup dans le board

        Board.GetComponent<board>().nameOfElement = (this.gameObject.name).ToString();
        Board.GetComponent<board>().isSelectClick = true;
        Board.GetComponent<board>().isMovable = false;
        Board.GetComponent<board>().nameOfElementInc++;
        Board.GetComponent<board>().ToKnowElement();
        //Board.GetComponent<board>().isSelect = false;
    }
}
