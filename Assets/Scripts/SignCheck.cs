using UnityEngine;

public class SignCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        //해당 스크립트를 컴포넌트로 지닌 객체와 충돌 객체의 tag가 "SeeSaw"이면 아래의 구문이 작동
        if (tag =="SeeSaw" && other.collider.tag == "SeeSaw" ) 
        {
            GetComponent<Renderer>().material.color = Color.green; //해당 스크립트를 컴포넌트로 지닌 객체의 마테리얼의 색상을 녹색으로 변환
        }
        //해당 스크립트를 컴포넌트로 지닌 객체와 충돌 객체의 tag가 "Slide"이면 아래의 구문이 작동
        else if (tag =="Slide" && other.collider.tag == "Slide" ) 
        {
            GetComponent<Renderer>().material.color = Color.green; //해당 스크립트를 컴포넌트로 지닌 객체의 마테리얼의 색상을 녹색으로 변환
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        //해당 스크립트를 컴포넌트로 지닌 객체와 충돌 이후 떨어져나간 객체의 tag가 "SeeSaw"이면 아래의 구문이 작동
        if (tag =="SeeSaw" && other.collider.tag == "SeeSaw" ) 
        {
            GetComponent<Renderer>().material.color = Color.red; //해당 스크립트를 컴포넌트로 지닌 객체의 마테리얼의 색상을 빨강으로 변환
        }
        //해당 스크립트를 컴포넌트로 지닌 객체와 충돌 이후 떨어져나간 객체의 tag가 "Slide"이면 아래의 구문이 작동
        else if (tag =="Slide" && other.collider.tag == "Slide" ) 
        {
            GetComponent<Renderer>().material.color = Color.red; //해당 스크립트를 컴포넌트로 지닌 객체의 마테리얼의 색상을 빨강으로 변환
        }
    }
}


