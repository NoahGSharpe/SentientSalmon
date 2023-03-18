using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimulationSettingsUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public TextMeshProUGUI valueText;
    private int value;
    private string sliderName;

    void Start()
    {
       sliderName = valueText.text; // save the name of the slider
       slider.onValueChanged.AddListener(delegate { ChangeValue(); }); // listen for updates to the slider being changed 
       ChangeValue(); // initial value
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ChangeValue() updates the slider value selected in Simulation Settings UI
    void ChangeValue()
    {
       valueText.text = sliderName + " " + slider.value;
    }
}
