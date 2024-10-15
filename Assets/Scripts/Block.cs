using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block // INHERITANCE
{
    protected MaterialPropertyBlock m_block = new MaterialPropertyBlock();
    public MaterialPropertyBlock block { get { return m_block; } } // ENCAPSULATION
    // Start is called before the first frame update

    public virtual void setColor()
    {
        Debug.Log("Red");
        m_block.SetColor("_BaseColor", Color.red);
    }

}
