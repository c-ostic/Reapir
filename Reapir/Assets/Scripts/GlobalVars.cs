using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars
{
    public static bool projectorBase, 
        projectorLens, 
        projectorFilm, 
        projectorReel, 
        coin,
        foundFootagePlayed;

    public static void setTrue(string pieceName)
    {
        switch(pieceName)
        {
            case "projectorBase":
                projectorBase = true;
                break;
            case "projectorLens":
                projectorLens = true;
                break;
            case "projectorReel":
                projectorReel = true;
                break;
            case "projectorFilm":
                projectorFilm = true;
                break;
            case "coin":
                coin = true;
                break;
            case "foundFootagePlayed":
                foundFootagePlayed = true;
                break;
            default:
                Debug.Log("Invalid string given to Global Variables");
                break;
        }
    }
}
