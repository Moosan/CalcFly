using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    //移動のボタンの処理
    bool leftMove;

    bool rightMove;

    bool downMove;

    bool upMove;


    public float speed = 7f;

    Animator animator;

    // Use this for initialization
    void Start () {
        animator = this.gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();

        Animation();
	}
    void Move()
    {
        this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        //右移動
        if (Input.GetKey("right") || rightMove == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        //左移動
        if (Input.GetKey("left") || leftMove == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up") || upMove == true)
        {
            this.transform.position += new Vector3(0, speed*Time.deltaTime, 0);
        }
        if (Input.GetKey("down") || downMove == true)
        {
            this.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }

    void Animation()
    {
        //まっすぐ飛ぶアニメーション
        animator.SetBool("flyStraight", true);

        //右アニメーション
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("flyRight", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("flyRight", false);

        }

        //左アニメーション
        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("flyLeft", true);
        }
        if (Input.GetKeyUp("left"))
        {
            animator.SetBool("flyLeft", false);

        }

        //上アニメーション
        if (Input.GetKeyDown("up"))
        {
            animator.SetBool("flyUp", true);
        }
        if (Input.GetKeyUp("up"))
        {
            animator.SetBool("flyUp", false);
        }

    }


    public void leftButtonDown()
    {
        leftMove = true;
        animator.SetBool("flyLeft", true);
    }
    public void leftButtonUp()
    {
        leftMove = false;
        animator.SetBool("flyLeft", false);
    }
    public void rightButtonDown()
    {
        rightMove = true;
        animator.SetBool("flyRight", true);
    }
    public void rightButtonUp()
    {
        rightMove = false;
        animator.SetBool("flyRight", false);
    }
    public void upButtonDown()
    {
        upMove = true;
    }
    public void upButtonUp()
    {
        upMove = false;
    }
    public void downButtonDown()
    {
        downMove = true;
    }
    public void downButtonUp()
    {
        downMove = false;
    }
}
