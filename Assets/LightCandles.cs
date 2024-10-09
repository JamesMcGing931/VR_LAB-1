using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.BuiltIn.ShaderGraph;
using UnityEngine;

public class LightCandles : MonoBehaviour
{
    public GameObject lighterOB;
    public GameObject CandleFlame;

    // Start is called before the first frame update
    void Start()
    {
        CandleFlame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "lighter")
        {
            CandleFlame.SetActive(true);
        }
    }
}
