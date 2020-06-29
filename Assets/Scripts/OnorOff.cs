/**
* OnorOff.cs set a boolean based on the checkbox or toggle state
* Author:  Lisa Walkosz-Migliacio  http://evilisa.com  12/18/2018
*/
using UnityEngine;
using UnityEngine.UI;

public class OnorOff : MonoBehaviour {

    public bool on;

    public void onChange()
    {
        if (GetComponent<Toggle>())
        {
            on = GetComponent<Toggle>().isOn;
        }
        else if (GetComponent<Slider>())
        {
            float value = GetComponent<Slider>().value;
            on = (value == 1) ? true : false;
            transform.Find("Background").GetComponent<Image>().color = on ? Color.green : Color.white;
        }
        string v = on ? "ON" : "OFF";
        Debug.Log($"toggle shows: {v}");
    }
}
