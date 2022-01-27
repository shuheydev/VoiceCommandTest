using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommandManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeRed()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void ChangeGreen()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void ChangeYellow()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
