using UnityEngine;
using UnityEngine.UI;
using System.Collections;//�ޥΨt�ζ��X�B�޲zAPI(��P�{��:�D�P�B�B�z)
using Tony;

namespace Tony
{
    public class Ruler : MonoBehaviour
    {
        [Header("�l�ܪ���v��")]
        public Transform target;
        [Header("�y�{��r")]
        public GameObject RuleText;

        //�߫}�ʵe���
        public Animator ani;
        //�߫}�n���ӷ�
        public AudioSource aud;
        //��l����
        public AudioClip WhistleSound;
        public int n;


        private void Start()
        {
            ani = GetComponent<Animator>();
            aud = GetComponent<AudioSource>();
            RuleText.SetActive(false);
        }
        private void Track()
        {
            Vector3 posA = new Vector3(target.position.x + 6.82f, target.position.y - 3f, target.position.z + 8.8f);
            transform.position = posA;
        }

        //�y�{ : �i�� �N�� ��u �|�j �g��
        public IEnumerator Rule()
        {
            if (DataBase.CatState == "�i��")
            {
                ani.SetTrigger("�}�l");
                ani.SetBool("���P", false);
                RuleText.GetComponent<Text>().text = "�i��";
                yield return new WaitForSeconds(0.5f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "�N��")
            {
                RuleText.SetActive(false);
                ani.SetBool("���P", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("���P", false);
                RuleText.GetComponent<Text>().text = "�N��";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "��u")
            {
                RuleText.SetActive(false);
                ani.SetBool("���P", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("���P", false);
                RuleText.GetComponent<Text>().text = "��u";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "�|�j")
            {
                RuleText.SetActive(false);
                ani.SetBool("���P", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("���P", false);
                RuleText.GetComponent<Text>().text = "�|�j";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "�g��")
            {
                RuleText.SetActive(false);
                ani.SetBool("���P", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("���P", false);
                RuleText.GetComponent<Text>().text = "�g��";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
        }
        private void LateUpdate()
        {
            //Track();
        }

    }
}

