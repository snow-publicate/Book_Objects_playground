using UnityEngine;

public class SignCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (tag =="SeeSaw" && other.collider.tag == "SeeSaw" )
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (tag =="Slide" && other.collider.tag == "Slide" )
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        if (tag =="SeeSaw" && other.collider.tag == "SeeSaw" )
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (tag =="Slide" && other.collider.tag == "Slide" )
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
