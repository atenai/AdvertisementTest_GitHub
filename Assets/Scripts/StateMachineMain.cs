using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMain : MonoBehaviour
{
    EngineBox pEBox;//EngineBox�^��pEBox�ϐ����`

    bool b_test = true;
    int i_num = 0;

    void Start()
    {
        pEBox = new EngineBox();//EngineBox���C���X�^���X
    }

    void Update()
    {
        if(b_test == true)
        {
            i_num++;
            if(i_num < 100)
            {
                //up(),down()�������_���ɌJ��Ԃ�
                pEBox.EngineBoxUp();//up�֐����g�p
                //Debug.Log(pEBox.EngineBoxState);//��Ԃ�\��
            }
            else
            {
                b_test = false;
                i_num = 0;
            }
        }
        else if(b_test == false)
        {
            i_num++;
            if(i_num < 100)
            {
                pEBox.EngineBoxDown();//down�֐����g�p
                //Debug.Log(pEBox.EngineBoxState);//��Ԃ�\��
            }
            else
            {
                b_test = true;
                i_num = 0;
            }
        }
 
    }
}
