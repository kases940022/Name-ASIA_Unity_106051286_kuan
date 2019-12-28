using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float turn;
    public Rigidbody rig;
    public Animator ani;
    public Transform tran;
    private void Update() 
    {
        jump();
        run();
    }
    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("跳躍", true);
        }
        else
        {
            ani.SetBool("跳躍", false);
        }
    }
    private void run() 
    {
        float h = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward* h * speed * Time.deltaTime);
        float v = Input.GetAxis("Horizontal");
        tran.Rotate(0, v * turn * Time.deltaTime, 0);

        ani.SetBool("跑步", h != 0 || v != 0);
    }

}
