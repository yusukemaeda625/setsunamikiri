using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninja_manager : MonoBehaviour {

    public float ninja_cooltime;
    public float ninja_attack;
    public float ninja_nextattack;
    bool isFirstAtack = true;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow5;
    public GameObject arrow6;
    public GameObject arrow7;
    public GameObject arrow8;
    public int arrow_direction;

    // Update is called once per frame
    void Update () {
        ninja_cooltime += Time.deltaTime;
        if ((isFirstAtack==true && ninja_cooltime >= ninja_attack) || (isFirstAtack==false && ninja_cooltime>= ninja_nextattack))
        {
            ninja_cooltime = 0;
            int varue = Random.Range(1, 9);
            switch (varue) {
                case 1:
                    Instantiate(arrow1, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(arrow2, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(arrow3, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(arrow4, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(arrow5, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(arrow6, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 7:
                    Instantiate(arrow7, new Vector2(0f, 4f), Quaternion.identity);
                    break;
                case 8:
                    Instantiate(arrow8, new Vector2(0f, 4f), Quaternion.identity);
                    break;
            }
            isFirstAtack = false;
            int var = Random.Range(1, 4);
            ninja_nextattack = ninja_attack * var;
        }

    }
}
