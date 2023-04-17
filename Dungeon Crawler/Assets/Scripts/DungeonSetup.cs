using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject NorthExit, SouthExit, EastExit, WestExit;
    public bool northOn, southOn, eastOn, westOn;

   
    void Start()
    {
        MasterData.setupDungeon();
    }

    void Update()
    {

    }
}
