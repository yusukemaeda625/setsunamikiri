using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteslinemanager : MonoBehaviour {
    public float timeOut;
    private float timeElapsed;
    public GameObject notes_r;
    public GameObject notes_l;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            Instantiate(notes_r, new Vector2( 2.4f, -4f), Quaternion.identity);
            Instantiate(notes_l, new Vector2( -2.4f, -4f), Quaternion.identity);

            timeElapsed = 0.0f;
        }
    }
}
