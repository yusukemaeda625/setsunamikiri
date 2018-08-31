using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmanager : MonoBehaviour {

    public float timeOut;
    private float timeElapsed;
    // Update is called once per frame
    void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            Destroy(gameObject);
        }
    }
}
