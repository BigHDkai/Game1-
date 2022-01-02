using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMoveButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Note;

    public void ShowNote()
    {
        Note.transform.localPosition = new Vector3(0,0,0);
    }

    public void DisNote()
    {
        Note.transform.localPosition = new Vector3(0,-500,0);
    }
}
