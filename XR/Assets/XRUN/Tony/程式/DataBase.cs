using UnityEngine;

namespace Tony
{
    public class DataBase : MonoBehaviour
    {
        public static DataBase instance; //��Ʈw���骫��   

        #region �򥻸��
        public static string Name;           //�W�l
        public static string Tall;           //����
        public static string Weight;         //�魫
        public static string Gender;         //�ʧO
        public static string Old;            //�~��
        #endregion

        #region �������
        public static string GunType;        //�j�K����
        public static string DistanceType;   //�Z������
        public static string TargetType;     //�v�����
        #endregion

        //�߫}���A
        public static string CatState;

        public void Awake()
        {
            instance = this;
        }
    }
}
