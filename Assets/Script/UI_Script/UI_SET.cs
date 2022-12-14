using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI总控制脚本
/// </summary>
public class UI_SET : MonoBehaviour
{
    //UI模型
    public Canvas Begin;
    public Canvas Success;
    public Canvas Fail;
    public Canvas Login;
    public Canvas Register;
    public Canvas Pause;
    public Canvas Quet;
    public Canvas Login_flag;
    public Canvas Select;
    public Canvas Select_num;
    public Canvas Classical;

    //UI的显示参数
    public bool set_begin;
    public bool set_success;
    public bool set_fail;
    public bool set_login;
    public bool set_register;
    public bool set_pause;
    public bool set_quet;
    public bool set_login_flag;
    public bool set_select;
    public bool set_select_num;
    public bool set_classical;

    // Start is called before the first frame update
    void Start()
    {
        //初始化UI的显示
        set_begin = true;
        set_success = false;
        set_fail = false;
        set_login = false;
        set_register = false;
        set_pause = false;
        set_quet = false;
        set_login_flag = false;
        set_select = false;
        set_select_num = false;
        set_classical = false;
}

    // Update is called once per frame
    void Update()
    {
        //通过显示参数控制UI的显示
        Begin.gameObject.SetActive(set_begin);
        Success.gameObject.SetActive(set_success);
        Fail.gameObject.SetActive(set_fail);
        Login.gameObject.SetActive(set_login);
        Register.gameObject.SetActive(set_register);
        Pause.gameObject.SetActive(set_pause);
        Quet.gameObject.SetActive(set_quet);
        Login_flag.gameObject.SetActive(set_login_flag);
        Select.gameObject.SetActive(set_select);
        Select_num.gameObject.SetActive(set_select_num);
        Classical.gameObject.SetActive(set_classical);
    }
}
