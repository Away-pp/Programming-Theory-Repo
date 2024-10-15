using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBlock : Block // INHERITANCE
{
    public override void setColor()
    {
        Debug.Log("Green");
        m_block.SetColor("_BaseColor", Color.green);
    }

}
