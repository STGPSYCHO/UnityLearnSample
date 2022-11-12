using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FindAndCallSampleScript : MonoBehaviour
{
    public AbstractSampleScript[] mem { get; private set; }

    [SerializeField]
    [ContextMenu("��������� ��� �������")]
    public void FindAllScriptsAndUse() 
    {
        //Debug.Log(GetComponents<AbstractSampleScript>());
        mem = GetComponents<AbstractSampleScript>();
        foreach(AbstractSampleScript i in mem) 
        {
            i.Use();
        }
    }
}
