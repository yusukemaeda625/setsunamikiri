using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_l_manager : MonoBehaviour {

    public float speed;

    // Update is called once per frame
    void Update () {

        transform.Translate(speed * Time.deltaTime , 0, 0);

        if (transform.position.x > 0)
        {
            Destroy(gameObject);
        }
    }
}
