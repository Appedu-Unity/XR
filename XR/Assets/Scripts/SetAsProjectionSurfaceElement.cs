using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsProjectionSurfaceElement : MonoBehaviour
{
    [Header("OVR���|�����@�ޥ�")]
    public OVRPassthroughLayer passthrough;
    [Header("��s�ܤƪ����L��")]
    public bool updateTransForm = false;
    // Start is called before the first frame update
    void Start()
    {
        passthrough.AddSurfaceGeometry(gameObject, updateTransForm);
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
