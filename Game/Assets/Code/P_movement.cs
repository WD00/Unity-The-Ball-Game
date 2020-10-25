using UnityEngine;

public class P_movement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
       rb.AddForce(0, 0, forwardForce * Time.deltaTime);
	
	if(Input.GetKey(KeyCode.LeftArrow))
	{
		rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
	}

	if(Input.GetKey(KeyCode.RightArrow))
	{
		rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
	}

	if(rb.position.y < -0.1f)
	{
		FindObjectOfType<Game_Main>().GameOver();
	}
    }
}
