using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class MouseDetect : MonoBehaviour
{

    public TextMeshProUGUI tmpg;
    public GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {
        tmpg.text = "Hover over any tool for information";
    }

    private void OnMouseEnter()
    {

        if (Cursor.visible)
        {
            tmpg.text = returnDescByID(gameobject.name);
        }

        Debug.Log(Cursor.visible);
        Debug.Log(returnDescByID(gameobject.name));
    }

    public void OnMouseExit()
    {

            tmpg.text = "";
        
    }

    public string returnDescByID(string gameObjName)
    {
        string desc;

        switch (gameObjName) {

            case "BHohlstrahlrohr":
                desc = "<size=30%>Fog Nozzle Size B\n<size=25%>Flow Rate: 215l/min\n<size=25%>Reach:28m";
                break;

            case "BHohlstrahlrohr2":
                desc = "<size=30%>Fog Nozzle Size B\n<size=25%>Flow Rate: 215l/min\n<size=25%>Reach:28m";
                break;

            case "Body1":
                desc = "<size=30%>Fire Hose Case\n<size=25%>Contains up to 3 C-sized fire hoses";
                break;

            case "Key":
                desc = "<size=30%>Hydrant key\n<size=25%>Is used to open surface level hydrants";
                break;

            case "Ladder":
                desc = "<size=30%>Ladder\n<size=25%>Is used to access buildings through windows, or in rare cases build containment pools";
                break;

            case "CStrahl1":
                desc = "<size=30%>Fog Nozzle Size C\n<size=25%>Flow Rate: 150l/min\n<size=25%>Reach:27m";
                break;

            case "CStrahl2":
                desc = "<size=30%>Fog Nozzle Size C\n<size=25%>Flow Rate: 150l/min\n<size=25%>Reach:27m";
                break;

            case "Druckbegrenzung":
                desc = "<size=30%>Pressure relief valve\n<size=25%>Prevents fire hoses from bursting of shock which occurs when a nozzle is closed too quickly";
                break;

            case "Druckbegrenzung2":
                desc = "<size=30%>Pressure relief valve\n<size=25%>Prevents fire hoses from bursting of shock which occurs when a nozzle is closed too quickly";
                break;

            case "idek":
                desc = "<size=30%>Pressure control unit\n<size=25%>Controls internal water pump pressure";
                break;

            case "Kugelhahn1":
                desc = "<size=30%>Ball valve\n<size=25%>Most commonly used directly at hydrants to regulate shock";
                break;

            case "Kugelhahn2":
                desc = "<size=30%>Ball valve\n<size=25%>Most commonly used directly at hydrants to regulate shock";
                break;

            case "mth":
                desc = "<size=30%>Converter\n<size=25%>Converts size B mounts to size C";
                break;

            case "mth2":
                desc = "<size=30%>Converter\n<size=25%>Converts size B mounts to size C";
                break;

            case "QuickAccess1":
                desc = "<size=30%>Internal water storage access\n<size=25%>Used when there is no immediate source of water, and as a buffer";
                break;

            case "QuickAccess2":
                desc = "<size=30%>Internal water storage access\n<size=25%>Used when there is no immediate source of water, and as a buffer";
                break;

            case "Schlauchhalter":
                desc = "<size=30%>Hose pins\n<size=25%>A box of pieces that can be used to tie fire hoses to fences, poles, or similar obstacles.";
                break;

            case "Sttzkrmmer":
                desc = "<size=30%>Branchpipe holder\n<size=25%>Most commonly used to connect to size B fire nozzles without a pistol grip for improved ergonomics";
                break;

            case "Sttzkrmmer2":
                desc = "<size=30%>Branchpipe holder\n<size=25%>Most commonly used to connect to size B fire nozzles without a pistol grip for improved ergonomics";
                break;

            default:
                desc = "no value assigned";
                break;
        }

        return desc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
