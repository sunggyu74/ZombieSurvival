using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//������Է¿� ���� �÷��̾� ĳ���͸� �����̴� ��ũ��Ʈ
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; //�յ� �������� �ӵ�
    public float rotateSpeed = 180f; //�¿� ȸ�� �ӵ�

    private PlayerInput playerInput; //�÷��̾� �Է��� �˷��ִ� ������Ʈ

    [SerializeField] private Rigidbody playerRigidbody; //�÷��̾� ĳ������ ������ �ٵ�
    private Animator playerAnimator; //�÷��̾� ĳ������ �ִϸ�����

    // Start is called before the first frame update
    void Start()
    {
        //����� ������Ʈ���� ���� ��������
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    // FixedUpdate�� ���� ���� �ֱ⿡ ���� �����
    private void FixedUpdate()
    {
        //���� ���� �ֱ⸶�� ������, ȸ��, �ִϸ��̼� ó�� ����
    }

    // �Է°��� ���� ĳ���͸� �յڷ� ������
    private void Move()
    {
        
    }

    // �Է°��� ���� ĳ���͸� �¿�� ȸ��
    private void Rotate()
    {

    }
}
