using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineBox
{
    //�R���X�g���N�^
    public EngineBox()
    {
        EngineBoxState = new EngineIdle();//�ŏ���Idle�̏��
    }
    public void EngineBoxUp()
    {
        EngineBoxState.up(this);
    }
    public void EngineBoxDown()
    {
        EngineBoxState.down(this);
    }
    public void changeState(EngineState newState)
    {
        EngineBoxState = newState;//�V������Ԃ�����iEngineState�^�̃N���X������j
    }
    public void nowState()
    {
        Debug.Log(EngineBoxState);
    }
    public EngineState EngineBoxState;
}
