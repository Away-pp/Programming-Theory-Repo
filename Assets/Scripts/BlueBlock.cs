using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBlock : Block // INHERITANCE
{
    public override void setColor()
    {
        Debug.Log("Blue");
        m_block.SetColor("_BaseColor", Color.blue);
    }
}
