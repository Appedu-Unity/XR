using UnityEngine;
using UnityEngine.UI;
using System.Collections;//�ޥΨt�ζ��X�B�޲zAPI(��P�{��:�D�P�B�B�z)

namespace Tony
{
    public class MenuManager : MonoBehaviour
    {
        public Dropdown DropGender;
        public Dropdown DropGun;
        public Dropdown DropDistance;
        public Dropdown DropTarget;
        public InputField InputFieldName;
        public InputField InputFieldTall;
        public InputField InputFieldWeight;
        public InputField InputFieldOld;
        public Text NameText;
        public Text GenderText;
        public Text TallText;
        public Text WeightText;
        public Text OldText;
        public GameObject AreYouSure;
        public GameObject BassData;
        public GameObject TypeData;
        public GameObject CannotBeNull;
        public GameObject CannotChoose;
        public Animator ani;
        public AudioSource aud;
        public AudioClip ButtunSound;
        public AudioClip StartGameSound;
        public AudioClip BackSound;

        public void Start()
        {
            ani = BassData.GetComponent<Animator>();
            DataBase.Gender = "�k";
            DataBase.GunType = "�Ů��j";
            DataBase.DistanceType = "10";
            DataBase.TargetType = "�T�w�v";
        }
        public void GetName(string getInput)
        {
            string name = getInput;
            DataBase.Name = name;
            CannotBeNull.SetActive(false);
        }
        public void GetOld(string getInput)
        {
            string old = getInput;
            DataBase.Old = old;
            CannotBeNull.SetActive(false);
        }
        public void GetTall(string getInput)
        {
            string tall = getInput;
            DataBase.Tall = tall;
            CannotBeNull.SetActive(false);
        }
        public void GetWeight(string getInput)
        {
            string weight = getInput;
            DataBase.Weight = weight;
            CannotBeNull.SetActive(false);
        }
        public void ButtunEnter()
        {
            if(DataBase.Name != null && DataBase.Tall != null && DataBase.Weight != null && DataBase.Old != null && DataBase.Name != "" && DataBase.Tall != "" && DataBase.Weight != "" && DataBase.Old != "")
            {
                aud.PlayOneShot(ButtunSound);
                NameText.text = "�m�W: " + DataBase.Name;
                GenderText.text = "�ʧO: " + DataBase.Gender;
                OldText.text = "�~��: " + DataBase.Old;
                TallText.text = "����: " + DataBase.Tall;
                WeightText.text = "�魫: " + DataBase.Weight;
                CannotBeNull.SetActive(false);
                AreYouSure.SetActive(true);
            }
            else
            {
                aud.PlayOneShot(ButtunSound);
                CannotBeNull.SetActive(true);
            }
        }
        public void Gender()
        {
            if(DropGender.value == 0) DataBase.Gender = "�k";
            else DataBase.Gender = "�k";
        }
        public void Gun()
        {
            if (DropGun.value == 0) DataBase.GunType = "�Ů��j";
            else if (DropGun.value == 1) DataBase.GunType = "�Ů�B�j";
            else if (DropGun.value == 2) DataBase.GunType = "�֮g��j";
            else if (DropGun.value == 3) DataBase.GunType = "��j";
            print(DataBase.GunType);
        }
        public void Distance()
        {
            if (DropDistance.value == 0) DataBase.DistanceType = "10";
            else if (DropDistance.value == 1) DataBase.DistanceType = "25";
            else if (DropDistance.value == 2) DataBase.DistanceType = "50";
            print(DataBase.DistanceType);
        }
        public void Target()
        {
            if (DropTarget.value == 0) DataBase.TargetType = "�T�w�v";
            else if (DropTarget.value == 1) DataBase.TargetType = "�w�V���v";
            else if (DropTarget.value == 2) DataBase.TargetType = "���w�V���v";
            print(DataBase.TargetType);
        }
        public void ButtunReset()
        {
            aud.PlayOneShot(BackSound);
            CannotBeNull.SetActive(false);
            DropGender.value = 0;
            InputFieldName.text = "";
            DataBase.Name = null;
            InputFieldTall.text = "";
            DataBase.Tall = null;
            InputFieldWeight.text = "";
            DataBase.Weight = "";
            InputFieldOld.text = "";
            DataBase.Old = null;
        }
        public void Next()
        {
            aud.PlayOneShot(ButtunSound);
            AreYouSure.SetActive(false);
            StartCoroutine(Nextani());
        }
        public IEnumerator Nextani()
        {
            ani.SetBool("�T�w�񧹸��", true);
            CannotChoose.SetActive(true);
            yield return new WaitForSeconds(1.8f);
            BassData.SetActive(false);
            TypeData.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            CannotChoose.SetActive(false);
        }
        public void ReTurn()
        {
            aud.PlayOneShot(BackSound);
            AreYouSure.SetActive(false);
        }
        public void EnterGame()
        {
            aud.PlayOneShot(StartGameSound);
        }
    }
}

