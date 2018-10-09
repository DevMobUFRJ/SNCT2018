using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTagging : MonoBehaviour {

    

    public enum Tags
    {
        Item1,
        Item2,
        Item3
    };

    public Tags myTag;

    public Tags GetMyTag()
    {
        return myTag;
    }
}
