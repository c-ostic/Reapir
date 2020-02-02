using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject greenHouseDoor, redHouseDoor, blueHouseDoor, graveyardDoor, boatHouseDoor;

    // Start is called before the first frame update
    void Start()
    {
        //graveyardDoor
        if (GlobalVars.projectorReel)
        {
            graveyardDoor.GetComponent<ChangeScene>().open = false;
        }
        else
            graveyardDoor.GetComponent<ChangeScene>().open = true;

        //blueHouseDoor
        if (GlobalVars.projectorReel && !GlobalVars.projectorBase)
            blueHouseDoor.GetComponent<ChangeScene>().open = true;
        else
            blueHouseDoor.GetComponent<ChangeScene>().open = false;

        //redHouseDoor
        if (GlobalVars.projectorBase && !GlobalVars.projectorLens)
            redHouseDoor.GetComponent<ChangeScene>().open = true;
        else
            redHouseDoor.GetComponent<ChangeScene>().open = false;

        //greenHouseDoor
        if (GlobalVars.projectorLens && !GlobalVars.projectorFilm)
        {
            Application.LoadLevel("videoTest");
            greenHouseDoor.GetComponent<ChangeScene>().open = true;
            
        }
        else
            greenHouseDoor.GetComponent<ChangeScene>().open = false;

        //boatHouseDoor
        if (GlobalVars.projectorFilm)
            boatHouseDoor.GetComponent<ChangeScene>().open = true;
        else
            boatHouseDoor.GetComponent<ChangeScene>().open = false;
    }

}
