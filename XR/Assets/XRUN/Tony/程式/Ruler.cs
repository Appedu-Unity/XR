using UnityEngine;
using UnityEngine.UI;
using System.Collections;//引用系統集合、管理API(協同程式:非同步處理)
using Tony;

namespace Tony
{
    public class Ruler : MonoBehaviour
    {
        [Header("追蹤的攝影機")]
        public Transform target;
        [Header("流程文字")]
        public GameObject RuleText;

        //貓咪動畫控制器
        public Animator ani;
        //貓咪聲音來源
        public AudioSource aud;
        //哨子音效
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

        //流程 : 進場 就位 填彈 舉槍 射擊
        public IEnumerator Rule()
        {
            if (DataBase.CatState == "進場")
            {
                ani.SetTrigger("開始");
                ani.SetBool("收牌", false);
                RuleText.GetComponent<Text>().text = "進場";
                yield return new WaitForSeconds(0.5f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "就位")
            {
                RuleText.SetActive(false);
                ani.SetBool("收牌", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("收牌", false);
                RuleText.GetComponent<Text>().text = "就位";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "填彈")
            {
                RuleText.SetActive(false);
                ani.SetBool("收牌", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("收牌", false);
                RuleText.GetComponent<Text>().text = "填彈";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "舉槍")
            {
                RuleText.SetActive(false);
                ani.SetBool("收牌", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("收牌", false);
                RuleText.GetComponent<Text>().text = "舉槍";
                yield return new WaitForSeconds(0.8f);
                RuleText.SetActive(true);
                aud.PlayOneShot(WhistleSound);
            }
            else if (DataBase.CatState == "射擊")
            {
                RuleText.SetActive(false);
                ani.SetBool("收牌", true);
                yield return new WaitForSeconds(0.5f);
                ani.SetBool("收牌", false);
                RuleText.GetComponent<Text>().text = "射擊";
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

