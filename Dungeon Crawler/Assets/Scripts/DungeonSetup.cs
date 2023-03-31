using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public bool north0n, south0n, east0n, west0n;

    void Start()
    {
        north0n = northExit.activeSelf;
        south0n = southExit.activeSelf;
        east0n = eastExit.activeSelf;
        west0n = westExit.activeSelf;


        if (northExit.activeSelf)
        {
            southExit.SetActive(false);
            westExit.SetActive(false);
            eastExit.SetActive(false);
        }
        if (southExit.activeSelf)
        {
            northExit.SetActive(false);
            eastExit.SetActive(false);
            westExit.SetActive(false);
        }
        if (eastExit.activeSelf)
        {
            northExit.SetActive(false);
            southExit.SetActive(false);
            westExit.SetActive(false);
        }
        if (westExit.activeSelf)
        {
            northExit.SetActive(false);
            eastExit.SetActive(false);
            southExit.SetActive(false);
        }
    }

void Update()
{

}

}