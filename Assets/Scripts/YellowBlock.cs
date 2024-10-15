using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlock : Block // INHERITANCE
{
    public override void setColor()
    {
        Debug.Log("Yellow");
        m_block.SetColor("_BaseColor", Color.yellow);
    }

}
