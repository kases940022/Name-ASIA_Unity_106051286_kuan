using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eatprop : MonoBehaviour
{
    [Header("寶箱數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;
    public int propCount;
    public int propTotal = 10;
    public bool finish;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text = "寶箱：" + propCount + " / 10";


            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }

    }
    private void Update()
    {
        Gameover();
    }
    private void Gameover()
    {
        if(finish)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.R))

            {
                SceneManager.LoadScene("迷宮"); 
            }
        }
    }
}
    
