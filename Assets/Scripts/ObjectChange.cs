using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChange : MonoBehaviour
{
    [SerializeField]
    public GameObject[] cubeArray;
    private int count;
    public GameObject cubeObj;

    void Start()
    {
        count = 0;
        //cubeArray[0�Ԗ�]�̃Q�[���I�u�W�F�N�g���C���X�^���X����
        //as���Z�q��GameObject�̔z��^����GameObject�^�ɕύX����cubeObj�Ɋi�[
        cubeObj = GameObject.Instantiate(cubeArray[count]) as GameObject;
    }

    public void CubeSet()
    {
        //CubeSet()�֐����Ă΂ꂽ�璆�g�����s����
        //cubeObj��j��
        Destroy(cubeObj);
        //�Ԑ��ڂ�+1����
        count++;
        //cubeArray[0�Ԗ�]�̃Q�[���I�u�W�F�N�g���C���X�^���X����
        //as���Z�q��GameObject�̔z��^����GameObject�^�ɕύX����cubeObj�Ɋi�[
        cubeObj = GameObject.Instantiate(cubeArray[count]) as GameObject;
        //�ő吔(2)�ɂȂ�����J�E���g��-1�ɕύX����
        //��������Ύ���+1��0�Ԗڂɖ߂鎖���ł����
        if (count == 2)
        {
            count = -1;
        }
    }
}
