using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //�÷��̾� ĳ���͸� �����ϱ� ���� ����� �Է��� ����
    //������ �Է°��� �ٸ� ������Ʈ�� ����� �� �ֵ��� ����

public class PlayerInput : MonoBehaviour
{
    public string moveAxisName = "Vertical"; //�յ� �������� ���� �Է��� �̸�
    public string rotateAxisName = "Horizontal"; //�¿� ȸ���� ���� �Է��� �̸�
    public string fireButtonName = "Fire1"; //�߻縦 ���� �Է� ��ư �̸�
    public string reloadButtonName = "Reload"; //�������� ���� �Է� ��ư �̸�

    //������Ƽ :�� �Ҵ��� ���ο����� ����
    public float move { get; private set; } // ������ ������ �Է°�
    public float rotate { get; private set; } // ������ ȸ�� �Է°�
    public bool fire { get; private set; } // ������ �߻� �Է°�
    public bool reload { get; private set; } // ������ ������ �Է°�


    // Update is called once per frame
    private void Update()
    {
        //���ӿ��� ���¿����� ����� �Է��� �������� ����
        if (GameManager.instance != null && GameManager.instance.isGameover)
        {
            move = 0;
            rotate = 0;
            fire = false;
            reload = false;
            return;
        }

        //move�� ���� �Է� ����
        move = Input.GetAxis(moveAxisName);
        //rotate�� ���� �Է� ����
        rotate = Input.GetAxis(rotateAxisName);
        //fire�� ���� �Է� ����
        fire = Input.GetButton(fireButtonName);
        //roload�� ���� �Է� ����
        reload = Input.GetButtonDown(reloadButtonName);
    }
}
