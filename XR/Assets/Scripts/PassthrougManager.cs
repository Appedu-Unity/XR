using System.Collections.Generic;
using UnityEngine;

public class PassthrougManager : MonoBehaviour

{
    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public List<Gradient> ColorMapGradient;
    [Header("�վ�UI�����}��")]
    public GameObject passthroughgstylerCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button,controller))
        {
            passthrough.hidden = !passthrough.hidden;
        }
        //UI�e���}��
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            passthroughgstylerCanvas.SetActive(!passthroughgstylerCanvas.activeSelf);
        }
    }
    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }
    public void SetColorMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = ColorMapGradient[index];
    }
    /// <summary>
    /// �G�׳]�m
    /// </summary>
    /// <param name="value"></param>
    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
        //�]�m�C��M�g�s�边
    }
    /// <summary>
    /// ���׳]�m
    /// </summary>
    /// <param name="value"></param>
    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
        //�]�m�C��M�g���
    }
    /// <summary>
    /// ��m�]�m
    /// </summary>
    /// <param name="value"></param>
    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }
    /// <summary>
    /// �q�L�󤸴�V�i���@�i�I�ưʤ���ҥε��ȵ�
    /// </summary>
    /// <param name="value"></param>
    public void SetgeRendering(bool value)
    {
        passthrough.edgeRenderingEnabled = value;
    }
    /// <summary>
    /// ����]�w
    /// </summary>
    /// <param name="value"></param>
    public void SetEdgeRed(float value)
    {
        //�Ыطs�C�� = �s�C��(����C��ȡA����C�⪽�O����ˡA�Ŧ�ƭȫO�����)
        Color newColor = new Color(value, passthrough.edgeColor.g, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor; 
    }
    public void SetEdgeGreen(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.r, value, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor;
    }
    public void SetEdgeBlue(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.a, passthrough.edgeColor.g, value);
        passthrough.edgeColor = newColor;
    }
}
