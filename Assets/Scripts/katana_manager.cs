using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katana_manager : MonoBehaviour
{

    private Vector2 touchStartPos;
    private Vector2 touchEndPos;

    public int Flick()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;
        float radian = Mathf.Atan2(directionY, directionX) * Mathf.Rad2Deg;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector2(Input.mousePosition.x,
                                        Input.mousePosition.y);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            touchEndPos = new Vector2(Input.mousePosition.x,
                                      Input.mousePosition.y);
        }

        if (radian < 0)
        {
            radian += 360;
        }

        //方向判定
        if (directionX == 0 && directionY == 0)
        {
            return 0;
        }
        else if (radian <= 22.5f || radian > 337.5f)
        {
            return 1;
        }
        else if (radian <= 67.5f && radian > 22.5f)
        {
            return 2;
        }
        else if (radian <= 112.5f && radian > 67.5f)
        {
            return 3;
        }
        else if (radian <= 157.5f && radian > 112.5f)
        {
            return 4;
        }
        else if (radian <= 202.5f && radian > 157.5f)
        {
            return 5;
        }
        else if (radian <= 247.5f && radian > 202.5f)
        {
            return 6;
        }
        else if (radian <= 292.5f && radian > 247.5f)
        {
            return 7;
        }
        else
        {
            return 8;
        }
    }

    public void Update()
    {
        int direction = Flick();
        if (direction == 1)
        {
            transform.Translate(0.2f, 0, 0);
        }
        else if (direction == 2)
        {
            transform.Translate(0.1f, 0.1f, 0);
        }
        else if (direction == 3)
        {
            transform.Translate(0, 0.2f, 0);
        }
        else if (direction == 4)
        {
            transform.Translate(-0.1f, 0.1f, 0);
        }
        else if (direction == 5)
        {
            transform.Translate(-0.2f, 0, 0);
        }
        else if (direction == 6)
        {
            transform.Translate(-0.1f, -0.1f, 0);
        }
        else if (direction == 7)
        {
            transform.Translate(0, -0.2f, 0);
        }
        else if (direction == 8)
        {
            transform.Translate(0.1f, -0.1f, 0);
        }
        else if (direction == 0)
        {
            transform.Translate(0, 0, 0);
        }
    }
}