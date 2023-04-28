using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject gameObjectToFollow;

    void Start()
    {

    }

    void Update()
    {
        this.transform.position = this.gameObjectToFollow.transform.position;
    }
}

