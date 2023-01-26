using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;    //Player의 속도를 담기 위한 speed 변수 선언 및 5f 할당
    private Rigidbody rigid;    //Rigidbody를 담기위한 rigid 변수 선언
    public float jumpPower = 5f;       //Player의 점프력을 담기 위한 jumpPower 변수 선언 및 5f 할당
 
    void Start()
    {
        rigid = GetComponent<Rigidbody>();      //Rigidbody 컴포넌트를 받아서 rigid 변수에 할당
    }   

    void Update(){
        //조건문을 통한 키보드와 Player 움직임의 대응 (좌우 회전 + 전후 이동)
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate (0f, -90f * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate (0f, 90f * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        //조건문을 통한 키보드와 Player 움짐임의 대응 (점프)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}

