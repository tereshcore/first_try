using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator move;
    void Start()
    {
        move.SetBool("isWalk", false);
    }

    // Update is called once per frame
    void Update()
    {
        // Найти объект по имени
        GameObject jump = GameObject.Find("PLAYER");
        // взять его компонент где лежит скорость
        PlayerMove PlayerMove = jump.GetComponent<PlayerMove>();
        // взять переменную скорости
        bool jumpcheck = PlayerMove.isGrounded;

        if ((Input.GetKeyDown(KeyCode.D) ^ Input.GetKeyDown(KeyCode.A)) && (jumpcheck == true))
        {
            move.SetBool("isWalk", true);
        }
        if ((Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.A)) && (jumpcheck == true))
        {
            move.SetBool("isWalk", true);
        }
        if ((Input.GetKeyUp(KeyCode.D) ^ Input.GetKeyUp(KeyCode.A)))
        {
            move.SetBool("isWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move.SetBool("isWalk", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            move.SetBool("isWalk", false);
        }
    }
}
