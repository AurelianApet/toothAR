using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject btnClose;
    public GameObject btnOk;
    public GameObject btnCancel;
    void Start()
    {
        
    }
    public void appClose()
    {
        Debug.Log("App close Click!");
        btnClose.SetActive(true);
    }
    public void clickOkBtn()
    {
        Application.Quit();
    }
    public void clickCancelBtn()
    {
        btnClose.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
